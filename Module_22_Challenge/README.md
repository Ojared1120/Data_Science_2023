
# Home Sales Analysis with SparkSQL

## Overview

This project involves using SparkSQL to analyze home sales data. The goal is to determine key metrics about home sales and utilize Spark features like temporary views, data partitioning, caching, and uncaching to optimize query performance.

## Instructions

### Data Analysis with SparkSQL

- **File Renaming**: Rename `Home_Sales_starter_code.ipynb` to `Home_Sales.ipynb`.
- **PySpark SQL Functions**: Import necessary PySpark SQL functions.
- **Data Loading**: Read `home_sales_revised.csv` into a Spark DataFrame.
- **Temporary Table Creation**: Create a temporary table named `home_sales`.

### SparkSQL Queries

- **Average Price for Four-Bedroom Houses**: Determine the average price for four-bedroom houses sold each year.
- **Average Price by Year Built**: Calculate the average price of homes with three bedrooms and three bathrooms for each year built.
- **Price Analysis for Specific Criteria**: Find the average price of homes each year with three bedrooms, three bathrooms, two floors, and a size of at least 2,000 square feet.
- **View Rating Analysis**: Analyze the "view" rating for homes costing more than or equal to $350,000 and determine the query runtime.

### Spark Features Utilization

- **Caching**: Cache the `home_sales` temporary table and verify the cache.
- **Cached Data Query**: Run the view rating query on cached data and compare runtime with uncached runtime.
- **Data Partitioning**: Partition the data by the "date_built" field and create a temporary table for the partitioned data.
- **Partitioned Data Query**: Execute the view rating query on the partitioned data and compare runtime.
- **Uncaching**: Uncache the `home_sales` temporary table and verify the uncaching.
