Why Angular? 
===========
- Speed up your web application 
- Avoid post-backs 
- Reduce total Byte transferred 
- Reduce Server-side code
- Less Client Side code than Jquery

Angular Syntax 
===============
module -  is like namespace to create scope that contain a set of related objects 
ng-app to define namespace 
ng-controller pass controller
$scope  is glue between view and model

MVC vs MVVM 
=============
MVC - Model View Controller Framework for easier to test and maitain. 
1. View pass control to Controller
2. Controller manipulate-> Model
3. Model fire events View

MVVM - refinement of MVC and used to facliate pesentation separation by using seperate abstract view of User Interface. 
View and ViewModel communicate using methods, properties and events. Bi directional data binding.


C# 6 Features. 
===============

String interpolation - variable subsitution, expansion
---------------------
 string color = "red"; 
 Console. WriteLine($"Color is {color}");

Static Members Import
-------------------- 
Using Static to import static members of the class into our namespace 
eg . using static System.Console; 
    public static void Main()

    {

        // Now, the System.Console static class is imported, so we

        // can use WriteLine directly

        WriteLine("Hello, World!");

    }

Demo 
====
Plurasight - Paul Training Company Project


