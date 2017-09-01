

function checkIfCheckboxIsChecked(id)
{
    return $(id).prop('checked');
}

function updateChartValues(
    numberOfActiveConnectionPools,
    numberOfInactiveConnectionPools,
    numberOfPooledConnections,
    numberOfNonPooledConnections,
    numberOfActiveConnections,
    numberOfFreeConnections,
    numberOfReclaimedConnections,
    softConnectsPerSecond,
    softDisconnectsPerSecond,
    requestsPerSecond,
    totalRequests
) {
            var line_data1 = {
                data: prepareChartArray(numberOfActiveConnectionPools),
                color: checkIfCheckboxIsChecked('#cbActiveConnectionPools') ? $('#lblActiveConnectionPools').css("color") : 'transparent'
    }

            var line_data2 = {
                data: prepareChartArray(numberOfInactiveConnectionPools),
                color: checkIfCheckboxIsChecked('#cbIctiveConnectionPools') ? $('#lblIctiveConnectionPools').css("color") : 'transparent'

               
            }
            var line_data3 = {
                data: prepareChartArray(numberOfPooledConnections),
                color: checkIfCheckboxIsChecked('#cbPooledConnections') ? $('#lblPooledConnections').css("color") : 'transparent'

             
            }
            var line_data4 = {
                data: prepareChartArray(numberOfNonPooledConnections),
                color: checkIfCheckboxIsChecked('#cbNonPooledConnections') ? $('#lblNonPooledConnections').css("color") : 'transparent'

              
            }
            var line_data5 = {
                data: prepareChartArray(numberOfActiveConnections),
                color: checkIfCheckboxIsChecked('#cbActiveConnections') ? $('#lblActiveConnections').css("color") : 'transparent'


               
            }
            var line_data6 = {
                data: prepareChartArray(numberOfFreeConnections),
                color: checkIfCheckboxIsChecked('#cbFreeConnections') ? $('#lblFreeConnections').css("color") : 'transparent'

                
            }
            var line_data7 = {
                data: prepareChartArray(numberOfReclaimedConnections),
                color: checkIfCheckboxIsChecked('#cbReclaimedConnections') ? $('#lblReclaimedConnections').css("color") : 'transparent'

               
            }
            var line_data8 = {
                data: prepareChartArray(softConnectsPerSecond),
                color: checkIfCheckboxIsChecked('#cbSoftConnectsPerSecond') ? $('#lblSoftConnectsPerSecond').css("color") : 'transparent'
            
            }
            var line_data9 = {
                data: prepareChartArray(softDisconnectsPerSecond),
                color: checkIfCheckboxIsChecked('#cbSoftDisconnectsPerSecond') ? $('#lblSoftDisconnectsPerSecond').css("color") : 'transparent'

         
            }

            var allValues = numberOfActiveConnectionPools.concat(numberOfInactiveConnectionPools).concat(numberOfPooledConnections).concat(numberOfNonPooledConnections).concat
                (numberOfActiveConnections).concat(numberOfFreeConnections).concat(numberOfReclaimedConnections).concat(softConnectsPerSecond).concat(softDisconnectsPerSecond);

       
            var dataList = [];

            dataList.push(line_data1);
            dataList.push(line_data2);
            dataList.push(line_data3);
            dataList.push(line_data4);
            dataList.push(line_data5);
            dataList.push(line_data6);
            dataList.push(line_data7);
            dataList.push(line_data8);
            dataList.push(line_data9);
           
            $.plot('#line-chart-adoNet', dataList, {
                grid: {
                    hoverable: true,
                    borderColor: '#f3f3f3',
                    borderWidth: 1,
                    tickColor: '#f3f3f3'
                },
                series: {
                    shadowSize: 0,
                    lines: {
                        show: true
                    },
                    points: {
                        show: false                       
                  }
                },
                lines: {
                    fill: false,
                },
                yaxis: {
                    show: true,
                    max: Math.max(...allValues) + 1,
                    min: Math.min(...allValues) - 1
                },
                xaxis: {
                    show: false,
                    max:10
                }
            })


            var line_app_data1 = {
                data: prepareChartArray(requestsPerSecond),
                color: checkIfCheckboxIsChecked('#cbRequestsPerSecond') ? $('#lblRequestsPerSecond').css("color") : 'transparent'
            }
            var line_app_data2 = {
                data: prepareChartArray(totalRequests),
                color: checkIfCheckboxIsChecked('#cbTotalRequests') ? $('#lblTotalRequests').css("color") : 'transparent'
            }


            var app_allValues = requestsPerSecond.concat(totalRequests).concat(numberOfPooledConnections);

            var app_dataList = [];

            app_dataList.push(line_app_data1);
            app_dataList.push(line_app_data2);


            $.plot('#line-chart-app', app_dataList, {
                grid: {
                    hoverable: true,
                    borderColor: '#f3f3f3',
                    borderWidth: 1,
                    tickColor: '#f3f3f3'
                },
                series: {
                    shadowSize: 0,
                    lines: {
                        show: true
                    },
                    points: {
                        show: false
                    }
                },
                lines: {
                    fill: false,
                },
                yaxis: {
                    show: true,
                    max: Math.max(...app_allValues ) + 1,
                    min: Math.min(...app_allValues ) - 1
                },
                xaxis: {
                    show: false,
                    max: 10
                }
            })
}

function prepareChartArray(inValues)
{
    var data = [];
    for (var i = 0; i < inValues.length; i += 1) {
        data.push([i, inValues[i]]);
    }
        return data;
}
