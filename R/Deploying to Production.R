#install.packages('shiny', repos='https://cran.rstudio.com/')
# Load Shiny 
library(shiny)

#Create a UI 
ui <- fluidPage("Hello World!")


#create a server 
server <- function(input, output){}


# Create a shiny app
shinyApp(
  ui = ui, 
  server = server)


#Create a UI with I/O Controls
ui <- fluidPage(
  titlePanel("Input and Output"), 
  sidebarLayout(
    sidebarPanel (
      sliderInput(
      inputId = "num",
      label = "Choose a Number", 
      min = 0, 
      max = 100, 
      value = 25)), 
    mainPanel(
      textOutput(
        outputId ="text"))))


#Create a server then maps input to output
server <- function(input, output){
  output$text <- renderText({
     paste("You selected", input$num)})
}

# Create a shiny app
shinyApp(
  ui = ui, 
  server = server)

#set working directory 
setwd("C:/JasmineAung/Projects/R")

#Load Train Model
load("Train.RData")


#Load color brewer library 
library(RColorBrewer)

#Create a color palette
palette <- brewer.pal(3,"Set2")


#Create user interface code
ui <- fluidPage(
   titlePanel("Iris Species Predictor") , 
   sidebarLayout(
     sidebarPanel(
       sliderInput(
         inputId = "petal.length",
         label = "Petal Length (cm)", 
         min = 1, 
         max = 7,
         value = 4
       ), 
       sliderInput(
         inputId = "petal.width", 
         label = "Petal Width (cm)", 
         min = 0.0, 
         max = 2.5, 
         step= 0.5, 
         value = 1.5
       )),
     mainPanel(
       textOutput(
         outputId = "text"),
        plotOutput(
          outputId = "plot"))))

#Create server code 
server <- function(input, output){
  output$text = renderText({
    #Create predictors 
    predictors <- data.frame(
      Petal.Length = input$petal.length, 
      Petal.Width = input$petal.width,
      Sepal.Length = 0,
      Sepal.Width = 0
    )
    
    #Make prediction 
    prediction = predict(
      object = model, 
      newdata = predictors, 
      type= "class")
    
    #Create prediction text 
    paste("The predicted species is", 
          as.character(prediction))
  })
  
  output$plot = renderPlot({
    #Create a scatterplot by species 
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
    
    #Draw predictor on plot
    points(
      x = input$petal.length, 
      y = input$petal.width, 
      col = "red", 
      pch = 4, #Plot Character
      cex = 2, # Plot Sample Size
      lwd = 2) # Line width
  })
  
}


# Create a shiny app
shinyApp(
  ui = ui, 
  server = server)

