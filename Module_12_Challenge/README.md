# NoSQL Challenge - UK Food Standards Agency Ratings Analysis

## Project Overview

This project involves analyzing food hygiene ratings data from various establishments across the United Kingdom, provided by the UK Food Standards Agency. The analysis is conducted for 'Eat Safe, Love', a food magazine, to assist their journalists and food critics in decision-making for future articles.

## Files

- **Module 12 Challenge files**: Starter files and resources are downloaded to assist in the project.

## Instructions

### Part 1: Database and Jupyter Notebook Set Up

- **Data Import**: `establishments.json` is imported into MongoDB, creating a database `uk_food` and a collection `establishments`.
- **Library Imports**: PyMongo and Pretty Print (pprint) are imported in the Jupyter notebook.
- **Mongo Client**: An instance of the Mongo Client is created.
- **Database Confirmation**: 
  - Listing of databases in MongoDB to confirm the creation of `uk_food`.
  - Listing of collections in `uk_food` to ensure `establishments` is present.
  - Display of one document from `establishments` using `find_one` and `pprint`.

### Part 2: Update the Database

- **New Establishment Addition**: A new restaurant, "Penang Flavours", is added to the database.
- **BusinessTypeID Update**: The `BusinessTypeID` for "Restaurant/Cafe/Canteen" is found and updated for "Penang Flavours".
- **Removal of Dover Establishments**: Establishments within the Dover Local Authority are removed from the database.
- **Data Type Conversion**: Latitude, longitude, and `RatingValue` fields are converted to appropriate data types using `update_many`.

### Part 3: Exploratory Analysis

- **Analysis Questions**: 
  - Identifying establishments with a hygiene score of 20.
  - Finding establishments in London with a `RatingValue` >= 4.
  - Top 5 establishments with a `RatingValue` of 5, sorted by lowest hygiene score, nearest to "Penang Flavours".
  - Count of establishments in each Local Authority area with a hygiene score of 0, sorted from highest to lowest.

## Requirements

- **Part 1**: Database and Jupyter Notebook setup.
- **Part 2**: Database updates and modifications.
- **Part 3**: Exploratory analysis based on specified questions.

