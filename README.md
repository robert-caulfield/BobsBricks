# BobsBricks

Welcome to BobsBricks, a mock LEGO website! This ASP.NET MVC project is responsible for pulling Products and Group Build information from an SQL Server database utilizing Entity Framework. The website was designed to be responsive and user-friendly, with a consistent theme made possible by Bootstrap and Bootswatch. On top of this Ajax was used to update the products page based on the user's input.

# Technology Used
- **ASP.NET MVC**:
- **Entity Framework**: Entity Framework is used to interact with the database. A code first design was used to create and manage the database.
- **Bootstrap and Bootswatch**: Bootstrap is used with a Bootswatch theme to maintain a consistent design throughout all pages.
- **Ajax**: Ajax is used to update the product index page dynamically given the users filter parameters.

# Database Design
For the database design I used a code first approach to create the Product and GroupBuilds table. Below is a diagram of the two tables with their attributes. 

- Primary Keys in bold
- A \* denotes a required field 

<p align="center">
  <img src="https://github.com/robert-caulfield/BobsBricks/blob/master/Images/DBSchema.png" alt="Image of DB Schema Design">
</p>

# Page Overviews

Contains a navbar that allows users to quickly access all pages.

## Home Controller:
Serves as the entry point to the website

### Index Page
- Headline and Sub-headline. 
- "Call to action" buttons for easier navigation to product and group build pages.
- List of the 3 latest products.

<p align="center">
  <img src="https://github.com/robert-caulfield/BobsBricks/blob/master/Images/Home.png" alt="Image of DB Schema Design">
</p>

## Product Controller
Serves as access to product information
### Index
- Contains a list of products ordered based on the given filters, which navigate the user to the product's detail page.
- Utilizes Ajax to dynamically update the webpage when the page initially loads and when the user changes a filter.
- Utilizes partial views for the list of products as well as each entry.

<p align="center">
  <img src="https://github.com/robert-caulfield/BobsBricks/blob/master/Images/Product_Index.png" alt="Image of DB Schema Design">
</p>

### Detail
- Displays information about the specific product.
- Includes a list of 3 recommended products.

<p align="center">
  <img src="https://github.com/robert-caulfield/BobsBricks/blob/master/Images/Product_Detail.png" alt="Image of DB Schema Design" >
</p>

## Group Build Controller
Serves as access to Group Build information
### Index
- Displays the list of the earliest group builds based on their StartTime attribute in ascending order.
- Does not display GroupBuilds that have already passed.
- Contains a list of selectable entries that navigates the user to the GroupBuild's detail page.
- Utilizes partial views for the list of Group Builds as well as each entry.

<p align="center">
  <img src="https://github.com/robert-caulfield/BobsBricks/blob/master/Images/GroupBuild_Index.png" alt="Image of DB Schema Design">
</p>

### Detail
- Displays the information about the specific Group Build.
- Includes a partial view of the related product entry, allowing users to see the product's detail page.

<p align="center">
  <img src="https://github.com/robert-caulfield/BobsBricks/blob/master/Images/GroupBuild_Detail.png" alt="Image of DB Schema Design">
</p>

# Acknowledgments
- Bootswatch for the United theme: https://bootswatch.com/united/
- DotNetMastery's course: https://www.youtube.com/watch?v=8NWC8BnxC8o
- BrickSet for images and product information: https://brickset.com/



