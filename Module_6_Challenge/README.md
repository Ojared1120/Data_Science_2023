# Python API Challenge - Weather Analysis

## Background

This project explores the fundamental question: "What is the weather like as we approach the equator?" Using Python requests, APIs, and JSON traversals, this analysis aims to provide a definitive answer, backed by data.

## Adding a .gitignore File

To protect API keys and sensitive information, a `.gitignore` file is used. It includes the following:


This ensures that `api_keys.py` is not tracked or shared publicly.

## Part 1: WeatherPy

In this section, a Python script visualizes the weather of over 500 cities at varying distances from the equator. The script uses the `citipy` Python library and the OpenWeatherMap API.

### Requirements

1. **Create Plots**: Scatter plots are created to showcase relationships between latitude and various weather variables:
   - Temperature
   - Humidity
   - Cloudiness
   - Wind Speed

2. **Compute Linear Regression**: Linear regression is computed for each relationship, with separate analyses for the Northern and Southern Hemispheres.

### Analysis

- **Scatter Plots**: Generated to visualize the data.
- **Linear Regression Plots**: Created for each weather variable against latitude, along with the regression line, formula, and r-values.

## Part 2: VacationPy

This section uses the weather data to plan future vacations. It involves map visualizations using the `geoViews` Python library and the Geoapify API.

### Tasks

1. **Map Creation**: A map displaying points for every city in the `city_data_df` DataFrame.
2. **Ideal Weather Conditions**: The DataFrame is narrowed down to find cities with ideal weather conditions.
3. **Hotel Search**: For each city, the Geoapify API is used to find the first hotel within 10,000 meters of the coordinates.
4. **Map with Hotels**: A map displaying hotels in the ideal cities, including hotel names and countries in the hover text.
