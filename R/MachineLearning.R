#predicting with machine learning

#Load the data 
data(iris)

#make a sequence of ramdomly generated values
#by setting randome number seed to an arbitrary number
#R will produce the same sequence of random numbers
set.seed(42)

#Randomly sample 100 to 150 row indexes
indexes <- sample(
  x = 1:150, size = 100)

#Inspect the random indexes 
print(indexes)


#Create a training set from indexes 100 rows
train <- iris[indexes,]

#Create a test set from remaining indexes 50 rows
test <- iris[-indexes,]

#install tree package 
#install.packages('tree', dep = TRUE)

# Load the decision tree package 
library(tree)

#Train a decision tree model  
# Species (Outcome variable), rest of the columns as 
# explanatory data set
model <- tree(
  formula = Species ~ ., 
  data = train
)

#Inspect the model 
summary(model)

#Vistualize the decision tree model 
plot(model)
text(model)

#Visualize the decision tree boundaries with
#dimensional scatterplot 
library(RColorBrewer)


#Create a color palette
palette <- brewer.pal(3, "Set2")

#Create a scatterplot colored by species 
plot(
x = iris$Petal.Length,
y = iris$Petal.Width,
pch= 19,
col = palette[as.numeric(iris$Species)], 
main = "Iris Petal Length vs. Width",
xlab = "Petal Length (cm)", 
ylab = "Petal Width (cm)"
)

#Plot the decison tree boundaries
partition.tree(
  tree = model, 
  label = "Species", 
  add = TRUE
)

####Compare Prediction Model with Actual Test Result###
predictions <- predict(
  object = model, #set tree model
  newdata = test,#set test data set
  type = "class" #set classification
  )

#Create a confusion matrix (Two Dimentional Matrix)
table(
  x = predictions, 
  y= test$Species)


# ###caret package (Classification and Regression training)

#install tree package 
install.packages('caret', dep = TRUE)

#Load the caret package 
library(lattice)
library(ggplot2)
library(caret)

#Evaluate the prediction results 
confusionMatrix(
   data = predictions, 
   reference = test$Species
  )

# Set working directory 
setwd("C:/JasmineAung/Projects/R")


#Save the tree model 
save(model, file="Tree.RData")
load("C:/JasmineAung/Projects/R/Tree.RData")

