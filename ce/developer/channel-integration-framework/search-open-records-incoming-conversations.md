---
title: "Search and open records on an incoming conversation | MicrosoftDocs"
description: "Read how you can use the Channel Integration Framework APIs to search and open records on an incoming conversation."
keywords: ""
ms.date: 05/08/2019
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 for Customer Engagement (online)"
  - "Dynamics 365 for Customer Engagement Version 9.x"
ms.assetid: 8C49AEE2-54BD-4FEC-A121-41CF2CFFEC2D
author: susikka
ms.author: susikka
manager: shujoshi
---
# Walkthrough: Search and open records on an incoming conversation

In this tutorial, we demonstrate how you can search and open records in Dynamics 365 on an incoming call using the Channel Integration Framework(CIF) APIs.

The sample given below covers four scenarios:

1. Customer's contact number matches one record in Dynamics 365. The record is retrieved using the [searchAndOpenRecords](reference/microsoft-ciframework/searchAndOpenRecords.md) API.
2. Customer's contact number matches multiple records of same entity type in Dynamics 365. The records are retrieved using the [searchAndOpenRecords](reference/microsoft-ciframework/searchAndOpenRecords.md) API.
3. Customer's contact number matches multiple records of multiple entity types in Dynamics 365. The Account entity and Contact entity records are searched for the contact number of the incoming call and then, the search results are displayed on the console.
4. Customer's contact number does not match any record in Dynamics 365, so we search and open empty results and then, create a new record for the customer using the [createRecord](reference/microsoft-ciframework/createRecord.md) API.

## Prerequisites

- Visual Studio 2017.
- A valid Microsoft Azure subscription is required to publish the sample app to Azure.

> [!IMPORTANT]
> This tutorial is in continuation of [Getting started with building a simple communication widget](getting-started-simple-widget.md). So, if you have not created a simple *Hello World!* widget yet that can be hosted on Channel Integration Framework, we suggest you read that first.

## Build the widget

1. Open the basic widget that you created using the steps mentioned in [Get started with building a simple communication widget](getting-started-simple-widget.md) in Visual Studio 2017.
2. Open the `Index.cshtml` file and replace the code in the file with the code given below. <br />
![Open Index.cshtml file from solution explorer](media/cif-helloworld-solution-explorer.PNG "Open Index.cshtml file from solution explorer")<br />

```html
<!DOCTYPE html>
<style>
    .button {
        background-color: #4FAFCD;
        border: none;
        color: white;
        padding: 15px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        margin: 4px 2px;
        cursor: pointer;
        height: 55px;
        width: 200px;
        font-size: 12px;
    }
</style>

<html>
<body>
    <br /><br />
    <script type="text/javascript" src="https://lpmars.crm.dynamics.com/webresources/Widget/msdyn_ciLibrary.js" data-crmurl="https://lpmars.crm.dynamics.com" data-cifid="CIFMainLibrary">
    </script>
    <script>
        function singlematch() {
            // The customer phone number matches one contact in Dynamics 365
            // Search and screen pop to the contact
            var contactno = "555-5555";
            var entityname = "account";

            Microsoft.CIFramework.searchAndOpenRecords(entityname, "?$select=name,telephone1&$filter=telephone1 eq '" + `${contactno}` + "&$search=" + `${contactno}`+"'", false).then(
                function success(result) {
                    res = JSON.parse(result);
                    console.log(`Record values: Name: ${res[0].name}, Telephone number: ${res[0].telephone1}`);
                },
                function (error) {
                    console.log(error.message);
                }
            );
                Microsoft.CIFramework.renderSearchPage(entityname, contactno).then(
                    function (success) {
                        console.log(success);
                    },
                    function (error) {
                        console.log(error);
                    }
                ); 
        }
        function multiplematchsingletype() {
            // More than one contacts are matched with same phone number
            // Search and show search results , then user selects one of the records, associate a record with the phone call
            var contactno = "555-5555";
            var entityname = "account";

            Microsoft.CIFramework.searchAndOpenRecords(entityname, "?$select=name,telephone1&$filter=telephone1 eq '" + `${contactno}` + "&$search=" + `${contactno}` + "'", false).then(
                function success(result) {
                    res = JSON.parse(result);
                    console.log(`Record values: Name: ${res[0].name}, Telephone number: ${res[0].telephone1}`);
                },
                function (error) {
                    console.log(error.message);
                }
            );
        }

        function multiplematchmultipletype() {
            // More than one type of records are matched with the same phone number - account/contact
            // search and show search results , then user selects one of the records, associate a record with the phone call
            var contactno = "555-5555";

            Microsoft.CIFramework.searchAndOpenRecords("account", "?$select=name,telephone1&$filter=telephone1 eq '" + `${contactno}` + "&$search=" + `${contactno}` + "'", false).then(
                function success(result) {
                    res = JSON.parse(result);
                    console.log(`Record values: Name: ${res[0].name}, Telephone number: ${res[0].telephone1}`);
                },
                function (error) {
                    console.log(error.message);
                }
            );

            Microsoft.CIFramework.searchAndOpenRecords("contact", "?$select=fullname,telephone1&$filter=telephone1 eq '" + `${contactno}` + "&$search=" + `${contactno}` + "'", false).then(
                function success(result) {
                    res = JSON.parse(result);
                    console.log(`Record values: Name: ${res[0].fullname}, Telephone number: ${res[0].telephone1}`);
                },
                function (error) {
                    console.log(error.message);
                }
            );
        }
        function nomatch() {
            // search and show empty search results
            // create new contact
            // associate new contact to session
            var contactno = "0000-00000-21";
            var callername = "Contoso Ltd.";

            Microsoft.CIFramework.searchAndOpenRecords("account", "?$select=name,telephone1&$filter=telephone1 eq '" + `${contactno}` + "&$search=" + `${contactno}` + "'", false).then(
                function success(result) {
                    res = JSON.parse(result);
                   // console.log(res);
                    // Check if the JSON response returned by the request is empty
                    if (isEmpty(res)) {
                        console.log("No records");
                        // Creating new Account record
                        var entityLogicalName = entityname;
                        var data = {
                            "name": callername,
                            "telephone1": contactno
                        }
                        var jsondata = JSON.stringify(data);

                        Microsoft.CIFramework.createRecord(entityLogicalName, jsondata).then(
                            function success(result) {
                                res = JSON.parse(result);
                                console.log("Account record created with ID: " + res.id);
                            })
                    }
                    else {
                        console.log(`Record values: Name: ${res[0].name}, Telephone number: ${res[0].telephone1}`);
                    } 
                },
                function (error) {
                    console.log(error.message);
                }
            );
        }
    </script>

    <button class="button" type="button" onclick="singlematch()">One matching record</button><br /><br />
    
    <button class="button" type="button" onclick="multiplematchsingletype()">More than one matching records of same type</button><br /><br />
    
    <button class="button" type="button" onclick="multiplematchmultipletype()">More than one matching records of different types</button><br /><br />
    
    <button class="button" type="button" onclick="nomatch()">No match</button><br /><br />

    
</body>
</html>
```

## Publish and configure the widget

Follow the steps mentioned in [Publish and configure the widget](getting-started-simple-widget.md#BKMK_publish) to publish the widget. The published widget should look like this.<br />

  ![Published sample widget in Unified Interface apps](media/cif-search-records-publish-app.PNG "Published sample widget in Unified Interface apps")<br />

## See also

[Get started with building a simple communication widget](getting-started-simple-widget.md)<br />
[Sample code for softphone integration](sample-softphone-integration.md)<br />
[Frequently asked questions](faq-channel-integration-framework.md)