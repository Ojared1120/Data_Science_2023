# Belly Button Biodiversity Dashboard

## Overview

The Belly Button Biodiversity Dashboard project involves creating an interactive web dashboard to explore the Belly Button Biodiversity dataset, which catalogs the microbes that colonize human navels. The dashboard allows users to visualize various aspects of the data, including demographic information, bacterial cultures, and sample data.

## Repository Structure

### Main Files and Folders

- **index.html**: The main HTML file for the dashboard.
- **samples.json**: JSON file containing the sample data.
- **app.js**: JavaScript file for handling the data visualization.
- **README.md**: Documentation file for the project.

### Static Files

- **static/js/**: Directory containing JavaScript files.

### Data Files

- **samples.json**: Contains sample data in JSON format.

## How to Run the Dashboard

1. **Clone the Repository**: Clone the repository to your local machine using the command:
   ```sh
   git clone [repository-url]
   ```

2. **Navigate to the Project Directory**: Move into the project directory:
   ```sh
   cd [project-directory]
   ```

3. **Open `index.html`**: Open the `index.html` file in a web browser to view the dashboard.

## Functionality

### Dropdown Menu

- **Test Subject ID No.**: Allows users to select a test subject ID to view specific data.

### Demographic Information Panel

- Displays demographic information such as ethnicity, gender, age, location, and washing frequency.

### Visualizations

- **Bar Chart**: Displays the top 10 OTUs (Operational Taxonomic Units) found in the selected sample.
- **Gauge Chart**: (Optional) Shows the belly button washing frequency.
- **Bubble Chart**: Visualizes all OTUs found in the selected sample.

## Data Source

The data used in this project is sourced from the Belly Button Biodiversity dataset, which catalogs the microbes that colonize human navels.

## Credits

This project was developed as part of a data visualization challenge. The dataset and initial setup were provided by the course instructors.

## Contributing

Contributions to this project are welcome. Please fork the repository and submit a pull request with your changes.
