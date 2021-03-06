#Assign Variable
x <- "Hello World!"
y = "kkkkk"

#Implicit printing
print(y)

#creating variables
l <- TRUE #boolean
i <- 123L #Integer Long
n <- 1.23 #Numberic (Decimal)
c <- "ACB 123" #Character
d <- as.Date("2001-02-03")

#Displaying variables 

l
i
n
c
d

#creating a function
PlusOne <- function(x) {x + 1}

#Invoking a function 
PlusOne(2)

# Creating a vector (One dimensional data) 
v <- c(1,2,3)
v

# Creating a sequence 
s <- 1:5 
s

# Creating matrix 
m <- matrix(data = 1:8, nrow= 2, ncol = 4)
m


# Create Multi-Dimentional Array
a <- array(data = 1:8, dim = c(2,2, 2))
a


# Creating a list
l <- list(TRUE, 123L, 2.34, "abc")
l

# Creating a factor 
categories <- c("Male", "Female", "Male", "Male", "Female")
factor <- factor(categories)
factor
levels(factor)
unclass(factor)


#Creating a data frame
df <- data.frame(
    Name = c("Cat", "Dog", "Cow", "Pig"), 
    HowMany= c(5,10,15, 20), 
    IsPet= c(TRUE, TRUE, FALSE, FALSE)
  ); 
df

#Indexing data frames by row and column 
df[1, 1]

#Indexing data frames by row
df[1,]

#Indexing data frames by column 
df[,2]
df[["HowMany"]]
df$HowMany

#Subsetting data frames
df[c(2,4),]
df[2:4,]
df[c(TRUE, FALSE, TRUE, FALSE),]
df[df$IsPet == TRUE,]
df[df$HowMany > 10,]
df[df$Name %in% c("Cat", "Cow"),]

#R is a vectorized language 
1 + 2

c(1, 2, 3) + c(4, 5, 6)
#Named vs. ordered arguments 
m <- matrix(data = 1:6, nrow=2, ncol= 3)
n <- matrix(1:6, 2, 3)
m == n
identical(m,n)


#Installing packages 
install.packages("dplyr")

#Loading packages 
library("dplyr")


#Viewing Help 
?data.frame