#Creating Statistical Models 

#Load the data 
data(iris)

#Peak at data
head(iris)

#Create a scatterplot
plot(
  x = iris$Petal.Length,
  y= iris$Petal.Width,
  main = "Iris Petal Length vs. Width", 
  xlab =  "Petal Length (cm),", 
  ylab =  "Petal Width (cm),"
)

#Create a linear regression model 
model <- lm(
  formula = Petal.Width ~ Petal.Length,
  data = iris  
)

#summarize the model 
summary(model)

#Draw a regression lin on plot 
lines(
  x = iris$Petal.Length, 
  y = model$fitted, 
  col = "red",
  lwd = 3)

#get correlation coefficient 
cor(x = iris$Petal.Length, 
    y = iris$Petal.Width)

#Predit new petal width value by passing new petal.length from the model 
predict(
  object = model, 
  newdata = data.frame(Petal.Length = c(2, 5, 7))
)

#=======Handling Big Data===============

#set working directory 
setwd("C:/JasmineAung/Exercise/Projects/R")

#Get Temp Directory and Set new temp directory 
getOption("fftempdir")
options(fftempdir = "C:/JasmineAung/Exercise/Projects/R")
getOption("fftempdir")

#install ff package 
install.packages('ff', dep = TRUE)

#load the ff package 
library(ff)
# Read a CSV file as ff data frame
irisff <- read.table.ffdf(
  file = "Iris.csv",
  FUN = "read.csv")

# Inspect the class
class(irisff)

# Inspect the column names
names(irisff)

# Inspect the first few rows
irisff[1:5,]

# Load the biglm package
library(biglm)

# Create a linear regression model
model <- biglm(
  formula = Petal.Width ~ Petal.Length,
  data = irisff)

# Summarize the model
summary(model)