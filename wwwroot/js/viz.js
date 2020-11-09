window.displayvega = (json) => {
    // Assign the specification to a local variable vlSpec.
    var vlSpec = {
        $schema: 'https://vega.github.io/schema/vega-lite/v4.json',
        data: {
            values: [
                { "a": "A", "b": 28 }, { "a": "B", "b": 55 }, { "a": "C", "b": 43 },
                { "a": "D", "b": 91 }, { "a": "E", "b": 81 }, { "a": "F", "b": 53 },
                { "a": "G", "b": 19 }, { "a": "H", "b": 87 }, { "a": "I", "b": 52 }
            ]
        },
        mark: 'bar',
        encoding: {
            x: { field: 'a', type: 'nominal' },
            y: {
                
                field: 'b',
                type: 'quantitative',
                axis: {
                    title: 'b'
                }
            }
        }
    };
    var obj = JSON.parse(json);
    vlSpec.data.values = obj;
    // Embed the visualization in the container with id `vis`
    vegaEmbed('#vis', vlSpec).then(function (result) {
        // Access the Vega view instance (https://vega.github.io/vega/docs/api/view/) as result.view        
    }).catch(console.error);    
}

