#set the working directory 
setwd("C:/JasmineAung/Exercise/Projects/R/New folder")

#Read a CSV data file
cars <- read.csv("Cars.csv")

#Peek at the data
head(cars)

#Create a frequency table 
table(cars$Transmission)

#Get the minimum value
min(cars$Fuel.Economy)

#Get the maximum value 
max(cars$Fuel.Economy)

#Get the mean value 
mean(cars$Fuel.Economy)

#Get the median value 
median(cars$Fuel.Economy)

#Get the quatile value 
quantile(cars$Fuel.Economy)

#Get the standard deviation 
sd(cars$Fuel.Economy)

#Get the correlation coefficient 
cor(x = cars$Cylinders,
    y = cars$Fuel.Economy)

#summarize the table
summary(cars)
