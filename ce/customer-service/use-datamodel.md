---
title: Use the out-of-the-box data model in your custom reports
description: Learn how to use the out-of-the-box data model in your custom reports. 
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 06/09/2023
ms.custom: bap-template
---

# Use the out-of-the-box data model in your custom reports

This articles describes how you can create a new report that leverages the out-of-the-box data model. You can also extend this report and add new metrics based on the available data within the Dynamics 365 Customer Service dataset.

## Prerequisites

- Your administrator must enable data model customization. More information: [Enable Power BI data model customization](model-customize-reports.md#enable-power-bi-data-model-customization)
- You must have the required [Power BI permissions](model-customize-reports.md#prerequisites).

## Create a new report based on Dynamics 365 Customer Service dataset

1. Go to [Power BI desktop](/power-bi/fundamentals/desktop-get-the-desktop), and then go to **File** > **New**.  

1. Select **Get data** > **Microsoft Fabric (Preview)**, and then from the list, select **Power BI dataset** or **Search for Power BI datasets**.

1. Select the appropriate dataset, depending on whether you require historical or real-time metrics. Make sure you select the data model from managed workspaces.

    The tables and attributes from the managed data model are now available for you to use in your report in the data panel.

1. Select **Connect**.
1. After you're done with your edits, select **File** > **Publish**, to publish the new report back to Power BI.  

> [!NOTE]
> We recommend that you don't use hidden out-of-the-box facts or dimension fields in your custom reports, as these fields might be modified or deleted in future updates.

## Add Dynamics 365 Customer Service dataset to existing reports
 
- Download a copy of the report. Make sure you download with a live connection to data online.
- If you'd like to edit the out-of-the-box copy of the report, download the report from the customer workspace.

To add Dynamics 365 Customer Service dataset to existing reports:

1. Go to the [Power BI service](https://msit.powerbi.com/), and then select the report from your custom workspace.
1. Select **File** > **Download this file**.
1. Select the option to download a copy of your report with a live connection to data online.
1. Select **Get data** > **Power BI datasets**.

1. Select the appropriate dataset, depending on whether you require historical or real-time metrics. Make sure you select the data model from managed workspaces.

    The tables and attributes from the managed data model are now available for you to use in your report in the data panel.

1. After you finish your edits, select **File** > **Publish**, to publish the updated report back to Power BI.  

## Extend the out-of-the-box data model

### Add new metrics based on data available in the Dynamics 365 Customer Service dataset

If you need to create a metric within the existing entities (as described in [Scenario 1 and Scenario 2](datamodel-overview.md#scenario-based-use-cases), perform the following steps:

1. Go to the [Power BI desktop](/power-bi/fundamentals/desktop-get-the-desktop) and open the report you want to edit.
    Make sure you use the steps described in [Add Dynamics 365 Customer Service dataset to existing reports](#add-dynamics-365-customer-service-dataset-to-existing-reports), to ensure that your report is connected to the Dynamics 365 Customer Service dataset.  

1. Right-click the entity for which you want to create your new metric.

1. Enter the Data Analysis Expressions (DAX) logic for real-time metrics after selecting the required attributes such as name and data type. For more information about DAX, go to [DAX function reference](/dax/dax-function-reference).

1. Save your measure and include it in your visualization as required.

1. Publish your newer version to Power BI by selecting **File** > **Publish**.
 
> [!NOTE]
> If you need to rename an existing column, you'll have to create a new local model.  

**Example**

Here's an example that describes how to create a new service level of 150 seconds for real-time reports.  

1. Go to the [Power BI service](https://msit.powerbi.com/), and then select the report from your custom workspace.

1. Download the real-time report with a live connection and open it in Power BI.

1. Right-click the **FactConversation** entity and select **New measure**.

    Refer to the **Data mappings for real-time reports** to get the logic used to calculate the out-of-the-box metrics, which you can use to build your logic.

1. Enter the following code:

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

1. Ensure that the format is **Percentage**, and then select **Save**.  

1. Replace the **Service level (60 seconds)** on the Summary Report page with the newly created Service level (150 seconds) measure.

1. Select **Save**, and then select **File > Publish** to Power BI.

### Add new metrics based on Dynamics 365 Customer Service dataset and external data

If you need to get additional data, both from within Dynamics 365 Customer Service as well as external data, as described in [Scenario 3 and Scenario 4](datamodel-overview.md#scenario-based-use-cases), perform the following steps:  

1. Go to [Power BI desktop](/power-bi/fundamentals/desktop-get-the-desktop) and open the report you want to edit.

    Make sure you use the steps described in [Add Dynamics 365 Customer Service dataset to existing reports](#add-dynamics-365-customer-service-dataset-to-existing-reports) to ensure that your report is connected to the dynamics data model.

1. Select the **Modeling** tab, and then select **Make changes to this model**.

    You may be asked to create a local model to bring in additional data sources. This creates a data model within the workspace where the report exists. This local model (for the report) uses a DirectQuery connection to connect to the Dynamics 365 model so you can leverage metrics from the dynamics model while adding your own.  

1. Select **Add a local model**.
1. On the **Connect to your data** dialog, select **Submit**.
1. If you need to bring additional attributes from Dynamics, select **Dataverse**. For other applications, use the appropriate source.
1. On the **Navigator** pane, select the entity, and then select **Transform data**.
1. On the **Connection Settings** dialog, select the preferred connection, and then select **OK**.

1. After the local model is created, select **Get data**, and then select the appropriate data source.  

1. On the **Modeling** tab, select **Manage relationship** to create relationships between the new entities that you've added with existing entities.  

1. Right-click the entity for which you want to create your new metric.

1. Enter the DAX logic after selecting the required attributes such as name and data type.

1. Save your measure and include it in your visualization as required.  

1. Publish your newer version to Power BI by selecting **File** > **Publish**.

**Example**

Here's an example that describes how to filter the out-of-the-box Customer Service historical reports by a user’s title.  

1. Go to [Power BI service](https://msit.powerbi.com/), and then select the report from your custom workspace.

1. Download the Customer Service historical analytics report with live connection and open it in Power BI.

1. Create the local model using the steps explained earlier.

1. In the **Navigator** pane, select the appropriate Dynamics Customer Service organization. As the metrics will be based on Dynamics 365 data, Dataverse connector is used.

1. From the list of entities, select the entity (or entities) that you need. Use the **system user** entity.  
 
1. Select **Transform data** to apply the necessary filters and to remove unwanted columns.

    As a best practice, make sure you pull only the data that's necessary to ensure optimal performance and refresh rates. You can choose to use **Import** mode or **DirectQuery** mode, depending on the your needs. In case of real-time reports, you may choose to use **DirectQuery** to help ensure that you get the latest data every time. To prevent any confusion, this entity can be named **UserTitle**.
 
    The new entity, **UserTitle**, and the **Title** attribute are loaded and available for you. To successfully create a relationship between this new entity and existing data, we need the User Id as well.  

1. Select the **Modeling** tab, and **Manage relationship** to create a new relationship between **DimAgent** entity and the newly created **UserTitle** entity using the agent Id attribute.  

    You can then add this as a filter to the existing report or add newer metrics if required based on this attribute.  

1. Select **Save**, and then select **File** > **Publish to Power BI**.
 
## Publish reports back to Dynamics 365 Customer Service  

After you've created the new reports, you can enable your Dynamics 365 users to be able to view these reports from the Customer Service workspace app. Work with your administrator to ensure that the viewers have appropriate access to [view and then embed](configure-customer-service-analytics-insights-csh.md) these reports in Dynamics 365.  

## Next steps

[Customize data models of historical and real-time analytics reports](model-customize-reports.md#customize-data-models-of-historical-and-real-time-analytics-reports)  
[Data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service)  
[Data mapping for real-time analytics](datamapping-realtime.md#data-mapping-for-real-time-analytics)  
[Overview of data model customization](datamodel-overview.md#overview-of-data-model-customization)
