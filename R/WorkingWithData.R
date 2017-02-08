#Working with Data

#set the working directory
setwd("C:/JasmineAung/Exercise/Projects/R/New folder")


# Read a tab-delimited data file
cars <- read.table(
               file="Cars.txt", 
               header = TRUE,
                  sep="\t",
                 quote="\"")


#Peek at the data
head(cars)

# Load the dplyr library
library(dplyr)

#select the subset of columns 
temp <- select(.data = cars, 
               Transmission, 
               Cylinders, Fuel.Economy)

# Inspect the results
head(temp)


#Filter a subset of rows
temp <- filter(.data = temp, 
               Transmission == "Automatic")

# Inspect the results
head(temp)


# Compute a new column 
temp <- mutate(.data = temp,
               Consumption = Fuel.Economy * 0.425)
         
# Inspect the results
head(temp)


#Group by a column 
temp <- group_by(.data = temp, Cylinders)

# Inspect the results
head(temp)
