---
title: "Marketing analytic reporting framework for Dynamics 365 Marketing | Microsoft Docs"
description: "The foundation for our marketing analytic reporting is the framework of M-Code, queries, functions, data connectors and parameter processing."
keywords: Marketing analytic reporting framework
ms.date: 11/11/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: cabeln
ms.author: cabeln
manager: 
ms.reviewer: kamaybac
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# The marketing analytic reporting framework (generic template)

Designed for the data analyst who is fluent in Power BI report building, the marketing analytic reporting framework provides an important foundation that includes the M-Code, queries, functions, data connectors, and parameter processing that is the core of every marketing analytics report example.

Use the following links to download a template for running the report on your own organization and/or a sample report filled with sample data.

|Download report template  |Download sample report  |
|---------|---------|
|[![Download template](media/IconDownloadTemplate30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/PowerBI-Templates/PowerBI%20Template%20-%20Dynamics%20365%20for%20Marketing.pbit)|[![Download sample report](media/IconDownloadReport30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/pbx%20files/PowerBI%20Template%20-%20Dynamics%20365%20for%20Marketing.pbix)|

You can find more downloads in the [marketing analytics reporting gallery](analytics-gallery-start.md#gallery).

## Building custom Marketing Analytics with Power BI

The file repository provides a set of Power BI files (.pbx) and respective template files (.pbit) that you can use to build your own marketing analytic reports. The focus of the Power BI code framework is to provide ready-built and easy-to-use data sources that connect to data from Dynamic 365 Marketing including date filters and on liner query building in M-code to access specific profile and interaction tables.

## Out-of-the-box connection dialog

> [!TIP]
> Connect to your data with ease!

When a template file is opened, the framework presents a [connection dialog](analytics-gallery-start.md#connect-dialog) for configuring and publishing marketing analytics.

![Parameter Dialog](media/Framework/Framework-ParameterDialog.png)

## The meta-model browser

> [!TIP]
> Browse the meta-model for profile and interactions types.

Each report comes with a set of hidden report pages, which can help you to browse the available types of profiles in your organization in CDS and all the interaction types that are referenced in the marketing model. You can select interaction types and study the attributes that you will be able to use for analytics reporting.

![Meta model browser](media/Framework/Framework-MetaBrowser.png)

## Your marketing interaction data stream

> [!TIP]
> Study the available interaction data and data generation over time.

Another valuable tool helps to validate the interaction data inflow in your marketing instance as it is reflected in the data arriving in your Azure storage. You can see quickly whether the data are arriving as expected and study which types of interaction data in what volume are being captured over time. This helps to select the use cases for marketing analytics, but also to troubleshoot the marketing analytic configuration and the processes in your marketing application in general.

![Interaction data flow](media/Framework/Framework-InteractionDataFlow.png)

## Working with queries in Power BI

When working with queries in Power BI we recommend that you:

- **Use pre-built query code to load, filter and analyze your data**  
    The framework comes with a rich set of pre-built queries, functions, parameters and tables that make it easy to access the data from your Marketing instance. You'll typically select the interaction types to load and then add queries for the profile and interaction data that you are looking for. Those tasks are well supported and often require  just one line of query code per interaction, plus a few desired formatting instructions.

- **Configure which interaction data should be considered by the report**  
    Over time, a marketing organization will collect large amounts of data, especially interactions, but also a set of signals emitted by the marketing automation engine.

A good practice is to only load the data that's required for your specific report. Although marketers will configure their reports with a maximum age limit for the interactions to consider, it's the duty of the data analyst who creates a marketing analytics report to specify which interaction types should be considered for loading. Limiting the amount of interaction types will greatly improve the refresh performance because the Power BI code will filter interaction data as early as possible.

![Configure which interaction data to load](media/Framework/Framework-InteractionConfiguration.png)

> [!TIP]
> Add queries for profiles and interactions

With the help of template code, it's easy to load data for selected profiles and interactions and then add the relations that connect the data .

The best way to learn how to achieve this is to look at the sample queries for profiles and interaction in the query editor. To load the data for a specific profile, add a new query and fill in one line of code with the respective profile/entity name, as shown for the `msdyncrm_marketingpage` entity in the following example: 

```console
let 
  Source = GetCDST_CustomProfileTable("msdyncrm_marketingpage")
in
  Source
```
Often you would add more operations to include only selected attributes and perform some formatting if needed.

Similarly, you can add queries to load interactions into your analytics report&mdash;also with one line of M-code.

![New interaction queries](media/Framework/Framework-AddInteractionQueries.png)

<!--Common pages-->
## Common report pages

> [!TIP]
> Out-of-the-box reports help you get started quickly with the marketing data in your organization.

Each template and sample report contains the following common pages (which help you explain your report to your audience) and a number of hidden data-management pages that you will need when you want to customize your report or develop your own reports.

<!-- kfm: I don't understand your use of bold and square brackets in the below list. It might be fine, or it may need cleaning up. -->

- The **Help page** is an empty page where you can document anything that you want your audience to know about when accessing the report. Each report page provides a help button at the top that opens this page.</li>

- The **"[Interaction data flow]" page** is hidden by default and provides insights into the volume of interaction data that your marketing organization generates over time.

    ![Interaction data flow report](media/Framework/InteractionDataFlow.png)

- The **"[Interaction files]" leaderboard** shows you the largest data generated by all the interaction types and data emitted by your marketing organization compared to the subset of data you actually consume in your analytic report.

    ![Interaction data file generation leaderboard](media/Framework/InteractionFilesLeaderboard.png)

- Two additional pages, **"[CDS-T entities]"** and **"[Interaction types]"**, provide a detailed lookup for any profile type and the full interaction data model available at your disposal for analytics reporting. You'll also find information about which interactions are enable for loading in your report configuration.
Please note that not all interaction types are supported by the data-publishing mechanic.

***Happy analytic reporting with Dynamics 365 Marketing!***
