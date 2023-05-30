---
title: Use the out-of-the-box data model in your reports
description: How-to description #Required; article description that's displayed in search results. Don't enclose in quotation marks. Do end with a period.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to #Required; don't change.
ms.collection: 
ms.date: 05/30/2023
ms.custom: bap-template #Required; don't change.
---


# Use the out-of-the-box data model in your reports

This articles describes how you can create a new report that leverages the out-of-the-box data model. You can also extend this report and add new metrics based on data available within the Dynamics 365 Customer Service dataset.

## Prerequisites

Do we have prerequisites?

## Create a new report

1. Open Power BI desktop.  

1. Go to **File** >**New**.  

1. Select **Get data**, and then select **Microsoft Fabric**, and from the list, select **Power BI dataset** or **Search for Power BI datasets**.

1. Select the appropriate data set, depending on your needs around historical or real-time metrics. Make sure you pick the model in the managed workspaces.

The tables and attributes contained within the managed data model are now available for you to leverage within your report in the data panel. Build visualizations as required and when complete, select **File** > **Publish**, to publish the new report back to Power BI.  

> [!NOTE]
> We recommend that you use hidden out-of-box facts or dimension fields in your custom reports with caution, as these fields might get modified or deleted in future updates.

## Add Dynamics data to existing reports
 
To add Dynamics data to existing reports, download a copy of the report you would like to add Dynamics data to. Make sure you download with live connection to data online. If you would like to edit the out-of-box copy of the report, download them from the customer workspace.

1. Open the downloaded file in Power BI.  

1. Select **Get data** **>** **Power BI data sets**.

1. Select the appropriate data set, depending on your needs around historical or real-time metrics. Make sure you pick the data model from the managed workspaces.

The tables and attributes from the managed data model are now available for you to leverage within your report in the data panel. Build visualizations as required and when complete select **File > Publish**, to publish the updated report back to Power BI.  

## Extend the out-of-box data model

### Add new metrics based on data available within the Dynamics 365 customer service dataset

If you are looking to create a metric within the existing entities (as described in scenarios #1 and #2), you should  

Open the report you want to edit in Power BI desktop. Make sure you use the steps described in Leveraging the out of box data model in your reports, to ensure that your report is connected to the dynamics data model.  

1. Right click on the entity in which you want to create your new metric 

2. Enter the DAX logic, after selecting the right attributes like name, data type.

3. Save your measure and include it in your visualization as you see fit  

4. Publish your newer version to Power BI by clicking on File -> Publish 
 
Note: If you choose to rename an existing column, you will have to create a new local model.  

Let’s walkthrough this scenario with an example. Let us create a new Service level 150 seconds in real-time reports.  

1. Open your Power BI service, and navigate to the customer workspace 

1. Download the real-time report with live connection and open it in Power BI   

1. Right-click on FactConversation entity and click on New measure.   

Refer to the <doc on reference> to get the logic used to calculate the out-of-box metrics, which you can use to build your logic. 

In this case enter:
``` 
Service level (150 seconds) =  

DIVIDE ( 

    SUMX ( 

        FactConversation, 

        IF ( 

            FactConversation[ConversationFirstWaitTimeInSeconds] <= 150 

                && FactConversation[IsAgentAccepted] 

                && NOT FactConversation[DirectionCode], 

            1, 

            0 

        ) 

    ), 

    SUMX ( 

        FactConversation, 

        IF ( 

            FactConversation[IsAgentAccepted] 

                && NOT FactConversation[DirectionCode], 

            1, 

            0 

        ) 

    ), 

    BLANK () 

) 

```

Ensure that the format is Percentage and click on save  

Replace the Service level (60 seconds) on the summary report page with the newly created Service level (150 seconds) measure 

Click on save and then Click on File -> Publish to Power BI   

## Add new metrics based on data unavailable within the Dynamics 365 customer service dataset

If you are looking to get additional data (both from within Dynamics Customer Service and outside of it) (as described in scenarios #3 and #4), you should  

Open the report you want to edit in Power BI desktop. Make sure you use the steps described in Leveraging the out of box data model in your reports, to ensure that your report is connected to the dynamics data model  

Click on Modeling tab and then click on Make changes to this model 

You may be asked to create a local model to bring in addition data sources. This creates a data model within the workspace where the report exists. This local model (for the report) uses DirectQuery to connect to the Dynamics model, as a result you can leverage metrics from the dynamics model while adding your own.  

Once the local model is created, click on Get data and pick the appropriate data source.  
 
If you are looking to bring additional attributes from Dynamics, use the Dataverse connector. For other applications, use the appropriate source.  

Click on the Modeling tab and select Manage relationship, to create relationships between the new entities that you have added with existing entities.  

Right click on the entity in which you want to create your new metric.

Enter the DAX logic, after selecting the right attributes like name, data type etc. A screenshot of a computer

Description automatically generated 

Save your measure and include it in your visualization as you see fit  

Publish your newer version to Power BI by clicking on File -> Publish 

 

Let’s walk through this scenario with an example. Let us allow for the out-of-box Customer service historical reports filtered by a user’s title.  

Open your Power BI service, and navigate to the customer workspace 

Download the Customer service historical analytics report with live connection and open it in Power BI   

Create the local model by following the steps outlined above 

As we are looking to build a metric based on Dynamics data, we will be leveraging Dataverse connector. In the navigator pane, select the appropriate Dynamics Customer Service organization.  
From the list of entities, select the entity (or entities) that you need. In this case, we will be leveraging the system user entity.  
A screenshot of a computer

Description automatically generated  
 
Use transform data to apply necessary filters and to remove unwanted columns. As a best practice, make sure you pull only the data that is necessary to ensure optimal performance and refresh rates. You can choose to use Import mode or DirectQuery mode depending on the your needs. In case of real-time reports, you may choose to use DirectQuery as you will get the latest data every time. To prevent any confusion, we can call this entity UserTitle 
 

The new entity UserTitle and the Title attribute are loaded and available for you. To successfully create a relationship between this new entity and existing data, we need the User Id as well.  

Click on the Modeling tab, and manage relationship to create a new relationship between DimAgent entity and  the newly created UserTitle entity using the agent Id attribute.  

You can then add this as a filter to the existing report or can add newer metrics if required based on this attribute.  

Select **Save** and then select **File** **>** **Publish to Power BI**.
 
## DevOps guidelines when leveraging model customization

To be added with inputs from Power BI team.  

## Publish reports back to Dynamics 365 Customer Service  

Once you have created the new reports, you can enable your Dynamics users to view these reports from within the Customer Service workspace. Work with your administrators to ensure the viewers have appropriate access (admin page – report hyperlink) and then to embed these reports on Dynamics (admin page – step 4 hyperlink).  

## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
