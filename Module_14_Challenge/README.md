# Belly Button Biodiversity Dashboard

## Project Overview

This project involves building an interactive dashboard to explore the Belly Button Biodiversity dataset, which catalogs the microbes that colonize human navels. The dataset reveals that a small handful of microbial species (operational taxonomic units, or OTUs) were present in more than 70% of people, while the rest were relatively rare.

## Files

- **Module 14 Challenge files**: Starter files and resources are downloaded to assist in the project.

## Instructions

### Dashboard Development

- **Data Reading**: Use the D3 library to read in `samples.json`.
- **Bar Chart**: 
  - Create a horizontal bar chart with a dropdown menu to display the top 10 OTUs found in an individual.
  - Use `sample_values` as the values, `otu_ids` as the labels, and `otu_labels` as the hovertext.
- **Bubble Chart**: 
  - Create a bubble chart to display each sample.
  - Use `otu_ids` for x values, `sample_values` for y values and marker size, and `otu_ids` for marker colors.
  - Use `otu_labels` for text values.
- **Sample Metadata**: Display an individual's demographic information and update it when a new sample is selected.
- **Dashboard Layout**: Create an interactive and user-friendly layout for the dashboard.

## Requirements

- **Bar Chart**: Initialization, dynamic updates, and correct data representation.
- **Bubble Charts**: Proper initialization, updates, and accurate data mapping.
- **Metadata and Deployment**: Error-free metadata display, dynamic updates, and successful deployment to GitHub Pages.
