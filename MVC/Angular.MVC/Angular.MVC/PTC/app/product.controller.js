(function () {
    'use strict';

    angular.module('app').controller('ProductController', ProductController);

    function ProductController($http) {
        var vm = this;
        var dataService = $http;
        // Hook up public search
        vm.resetSearch = resetSearch;
        vm.searchImmediate = searchImmediate;
        vm.search = search;
        vm.products = [];
        vm.product = {};
        vm.categories = [];
        vm.searchCategories = [];      
        vm.searchInput = {
            selectedCategory: {
                CategoryId: 0,
                CategoryName: ''
            },
            productName: ''
        };
        vm.addClick = addClick;
        vm.editClick = editClick;
        vm.cancelClick = cancelClick;
        vm.deleteClick = deleteClick;
        vm.saveClick = saveClick;
       

        const pageMode = {
            LIST: 'List',
            EDIT: 'Edit',
            ADD: 'Add'
        }
        vm.uiState = {
            mode: pageMode.LIST,
            isDetailAreaVisible: false,
            isListAreaVisible : true, 
            isSearchAreaVisible :true, 
            isValid:true, 
            messages:[]
        }

        productList();
        searchCategoriesList();
        categoryList();

        function initEntity() {
            return {
                ProductId: 0,
                ProductName: '',
                IntroductionDate:
                    new Date().toLocaleDateString(),
                Url: 'http://www.pdsa.com',
                Price: 0,
                Category: {
                    CategoryId: 1,
                    CategoryName: ''
                }
            }
        }
        function setUIState(state) {
            vm.uiState.mode = state;
            vm.uiState.isDetailAreaVisible = (state == pageMode.ADD || state == pageMode.EDIT);
            vm.uiState.isListAreaVisible = (state == pageMode.LIST);
            vm.uiState.isSearchAreaVisible = (state == pageMode.LIST);
        }
        function addClick() {
            vm.product = initEntity();
            setUIState(pageMode.ADD);
        }
        function editClick(id) {            
            productGet(id);           
            setUIState(pageMode.EDIT);
        }
        function cancelClick() {
            setUIState(pageMode.LIST);
        }
        function deleteClick(id) {
            if (confirm("Delete this product?")) {
                deleteData(id);
            }
        }
        function saveClick() {
            if (validateData())
            {
                if (vm.uiState.mode == pageMode.ADD)
                {
                    insertData();
                }
                else
                {
                    updateData();
                }
            }
            console.log("Save Complete ::" + vm.uiState.mode);
        }

        function searchImmediate(item) {
            if ((vm.searchInput.selectedCategory.CategoryId == 0 ? true : vm.searchInput.selectedCategory.CategoryId == item.Category.CategoryId) &&
             (vm.searchInput.productName.length == 0 ? true : (item.ProductName.toLowerCase().indexOf(vm.searchInput.productName.toLowerCase()) >= 0))) {
                return true;
            }

            return false;
        }
        function search() {
         
            var searchEntity = {
                CategoryId: vm.searchInput.selectedCategory.CategoryId,
                ProductName: vm.searchInput.productName
            };

            dataService.post("api/Product/Search", searchEntity).
                then(function () {
                    vm.products = result.data;
                    setUIState(pageMode.LIST);
                },
                function (error) { handleException(error); }

            );

        }
        function resetSearch() {
            vm.searchInput = {
                selectedCategory: {
                    CategoryId: 0,
                    CategoryName: ''
                },
                productName: ''
            };

            productList();
        }
        function searchCategoriesList() {
            dataService.get("/api/Category/GetSearchCategories")
            .then(function (result) {
                vm.searchCategories = result.data;
            },
            function (error) {
                handleException(error);
            });
        }
        function productGet(id) {
            // Call Web API to get a product
            dataService.get("/api/Product/" + id)
              .then(function (result) {
                  // Display product
                  vm.product = result.data;

                  // Convert date to local date/time format
                  if (vm.product.IntroductionDate != null) {
                      vm.product.IntroductionDate =
                        new Date(vm.product.IntroductionDate).
                        toLocaleDateString();
                  }
              }, function (error) {
                  handleException(error);
              });
        }

        function productList() {
            dataService.get("/api/Product")
            .then(function (result) {
                vm.products = result.data;
                setUIState(pageMode.LIST);
            },
            function (error) {
                handleException(error);
            });
        }
        function categoryList() {
            dataService.get("/api/Category")
              .then(function (result) {
                  vm.categories = result.data;
              }, function (error) {                
                  handleException(error);
              })
        }
        
        function insertData()
        {
            dataService.post("/api/Product", vm.product)
                       .then(function (result) {
                           vm.product = result.data;
                           vm.products.push(vm.product);                      
                           setUIState(pageMode.LIST);
                       }, function (error) {
                           handleException(error);
                       });
        }
        function updateData()
        {  
            dataService.put("/api/Product/" +
                    vm.product.ProductId,
                    vm.product)
                        .then(function (result) {
                            vm.product = result.data;
                            
                            //Get Index of this product 
                            var index = vm.products.map(function (p) {
                                return p.ProductId;
                            }).indexOf(vm.product.ProductId);
                            
                            //Update product in array
                            vm.products[index] = vm.product;

                            setUIState(pageMode.LIST);
                        },
                        function (error) {                            
                            handleException(error);
                        });
        }
      

        function deleteData(id) {
            dataService.delete("/api/Product/" + id)
                        .then(function (result) {
                            vm.product = result.data;

                            //Get Index of this product 
                            var index = vm.products.map(function (p) {
                                return p.ProductId;
                            }).indexOf(id);

                            //Remove product in array
                            vm.products.splice(index, 1);

                            //Set it back List Mode
                            setUIState(pageMode.LIST);
                        },
                        function (error) {
                            handleException(error);
                        });
        }

        function validateData()
        {
            var ret = true;

            //fix up date(IE 11 bug workaround)
            vm.product.IntroductionDate =
                vm.product.IntroductionDate
                 .replace(/\u200E/g, '');

            //TODO: Perform Validation here
            return ret;

        }
        function handleException(error) {
            vm.uiState.isValid = false;
            vm.uiState.messages = [];
            var msg = {
                property: 'Error',
                message: ''
            };
           
            switch (error.status) {
                case 400:
                    //bad request
                    break;
                case 404:
                    //Not Found
                    msg.message = 'The product you were ' +
                                  'requesting could not be found';
                    vm.uiState.messages.push(msg);
                    break;
                case 500: //Internal error
                    msg.message = error.data.ExceptionMessage;
                    vm.uiState.messages.push(msg);
                    break;
                default:
                    msg.message = 'Status:' + error.status +
                                    ' - Error Message:' +
                                    error.statusText;
                    vm.uiState.messages.push(msg);
                    break;
            }            
        }
    }
})();