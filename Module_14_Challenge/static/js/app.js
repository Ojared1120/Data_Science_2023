function init() {
    // Read the data
    d3.json("samples.json").then((data) => {
        // Populate dropdown
        var names = data.names;
        var dropdown = d3.select("#selDataset");
        names.forEach((name) => {
            dropdown.append("option").text(name).property("value", name);
        });

        // Create initial plots and metadata display
        var firstSample = names[0];
        updateCharts(firstSample);
        updateMetadata(firstSample);
    });
}

function updateCharts(sample) {
    d3.json("samples.json").then((data) => {
        var samples = data.samples;
        var resultArray = samples.filter(sampleObj => sampleObj.id == sample);
        var result = resultArray[0];

        // Bar Chart
        var barData = [{
            x: result.sample_values.slice(0, 10).reverse(),
            y: result.otu_ids.slice(0, 10).map(otuID => `OTU ${otuID}`).reverse(),
            text: result.otu_labels.slice(0, 10).reverse(),
            type: "bar",
            orientation: "h"
        }];

        Plotly.newPlot("bar", barData);

        // Bubble Chart
        var bubbleData = [{
            x: result.otu_ids,
            y: result.sample_values,
            text: result.otu_labels,
            mode: 'markers',
            marker: {
                size: result.sample_values,
                color: result.otu_ids,
                colorscale: "Earth"
            }
        }];

        Plotly.newPlot("bubble", bubbleData);
    });
}

function updateMetadata(sample) {
    d3.json("samples.json").then((data) => {
        var metadata = data.metadata;
        var resultArray = metadata.filter(sampleObj => sampleObj.id == sample);
        var result = resultArray[0];
        var PANEL = d3.select("#sample-metadata");

        PANEL.html("");
        Object.entries(result).forEach(([key, value]) => {
            PANEL.append("h6").text(`${key.toUpperCase()}: ${value}`);
        });
    });
}

d3.selectAll("#selDataset").on("change", handleChange);

function handleChange() {
    var newSample = d3.select(this).property("value");
    updateCharts(newSample);
    updateMetadata(newSample);
}

init();
