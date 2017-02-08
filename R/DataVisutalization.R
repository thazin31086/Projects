#set working directory
setwd("C:/JasmineAung/Exercise/Projects/R/New folder")

#Read CSV File
cars <- read.csv("Cars.csv")

#Install Packages
install.packages('ggplot2', dep = TRUE)

#Load the ggplot2 Library 
library(ggplot2)

# Create a frequency bar chart 
ggplot(
  data = cars, 
  aes(x= Transmission)) + 
  geom_bar() + #bAR cHART 
  xlab("Transmission Type") + 
  ylab("Count of Cars")

#Create a histogram
ggplot(
  data = cars, 
  aes(x = Fuel.Economy)) + 
  geom_histogram(bins = 10) + 
  ggtitle("Distribution of Fuel Economy")+ 
  xlab("Fuel Economy (mpg)") +
  ylab("Count of Cars")

#Create a density plot
ggplot(
  data = cars, 
  aes(x = Fuel.Economy)) + 
  geom_density() + 
  ggtitle("Distribution of Fuel Economy")+ 
  xlab("Fuel Economy (mpg)") +
  ylab("Density")

#Create a scatterplot
ggplot(data = cars, 
       aes(x = Cylinders, 
           y = Fuel.Economy))+ 
       geom_point() + 
       ggtitle("Fuel Economy by Cylinders") + 
       xlab("Number of Cylinders") + 
       ylab("Fuel Economy (mpg)")


