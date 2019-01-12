---
title: "User Power BI to create custom analytics (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Describes how to set up data sources in Dynamics 365 for Marketing to make them available to Power BI, and how to download and connect a Power BI template to them"
keywords: tutorial; templates; email; customer journey; marketing page; page
ms.date: 12/17/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 4479aca4-9f7f-40fa-9b78-515f98e47d26
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Preview: Create custom analytics with Power BI

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] provides a wide selection of built-in analytics throughout the application. But you can also create your own custom analytics and reports from your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] data by using [!include[](../includes/pn-power-bi.md)]. We provide endpoints that you can use to connect [!include[](../includes/pn-power-bi.md)] to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], plus a downloadable [!include[](../includes/pn-power-bi.md)] template that you can open in [!include[](../includes/pn-power-bi-desktop.md)], connect to your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] data sources and then customize as needed. When you're done setting it up, you can publish and share your [!include[](../includes/pn-power-bi.md)] report using the standard [!include[](../includes/pn-power-bi.md)] online tools.

> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  

## Data sources for custom analytics

To create custom analytics, you can connect two different data sources, each of which provides a different type of data:

- **Profile data** includes the entities and records that you see, edit, and create when working directly in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]. These include common entities like contacts, accounts, leads, events, customer journeys, and more. You'll use the [!include[](../includes/pn-power-bi.md)] data connector called "Common Data Services for Apps" for this type of data.
- **Interaction data** includes information about how your contacts interacted with your marketing initiatives, including email opens, email clicks, event registrations, page submissions, and more. You can see this type of information when you look at the insights built into [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], but you can't create these records nor view them directly. In the current release, you'll use the [!include[](../includes/pn-power-bi.md)] "[!include[](../includes/pn-azure-blob-storage.md)]" connector for this type of data. In future releases you'll also be able use the dataflow connector.

You'll be able to connect directly to your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]  database from [!include[](../includes/pn-power-bi.md)] to fetch your profile data, but to access interaction data you'll need to set up [!include[](../includes/pn-azure-blob-storage.md)], configure [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]  to save interaction data there, and then connect [!include[](../includes/pn-power-bi.md)] to your blob storage.

## Set up [!include[](../includes/pn-azure-blob-storage.md)] and connect it to Marketing

1. Sign into [portal.azure.com](https://portal.azure.com) using the same account where you are running [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

1. If you don't already have one, then create a general-purpose storage account in the [!include[](../includes/pn-azure-blob-storage.md)] as described in [Quickstart: Upload, download, and list blobs using the Azure portal](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-portal).

    > [!NOTE]
    > Your general-purpose storage account can be either V1 or V2. Both will work with the [!include[](../includes/pn-power-bi.md)] template supplied by [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)], but we recommend using V2 if possible because it will support more advanced [!include[](../includes/pn-power-bi.md)] capabilities in the future.

1. Create a blob storage container in your storage account, also as described in [Quickstart: Upload, download, and list blobs using the Azure portal](https://docs.microsoft.com/azure/storage/blobs/storage-quickstart-blobs-portal).

1. Launch the Microsoft [!include[](../includes/pn-azure-shortest.md)] Storage Explorer, which is a desktop app, and connect it to your [!include[](../includes/pn-azure-shortest.md)] account. If  you don't already have it, you can download if for free from [https://azure.microsoft.com/features/storage-explorer/](https://azure.microsoft.com/features/storage-explorer/).

1. In the Storage Explorer, navigate down to the blob storage container you just created.

    ![Azure Storage Explorer](media/custom-analytics-storage-explorer.png "Azure Storage Explorer")

1. Right-click on your blob storage container and then select **Get shared access signature** from the context menu. The **Shared Access Signature** dialog opens.

    ![The Shared Access Signature dialog](media/custom-analytics-sas.png "The Shared Access Signature dialog")

    Make the following settings:

    - Choose a **Start time** and **Expiry time** to establish the period during which your signature will remain valid.
    - Enable all four **Permissions** by selecting their check boxes.

1. Select **Create** to create the signature. The dialog refreshes to show a **URL** and **Query string**. Select the **Copy** button to copy the **URL** shown here and paste in a temporary text file so you can use it later in this procedure.

    ![Copy the URL](media/custom-analytics-sas-created.png "Copy the URL")

1. Sign into [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and go to **Settings** > **Advanced settings** > **Marketing settings** > **CDS-A connector settings**. The **Marketing Settings** page opens. If a record is already listed here, then select it to open it; otherwise, select **New** from the command bar to create a new record.

1. The **CDS-A Connector Configuration** page opens.

    ![CDS-A connector configuration](media/custom-analytics-cds-a-config.png "CDS-A connector configuration")

    Make the following settings:

    - **Name** : Enter a name to identify this configuration record.
    - **Export to blob storage URL** : Paste the URL you copied earlier in this procedure.

    > [!NOTE]
    > The URL you pasted here includes a connection string to connect to your blob storage. [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] will use this to set up a connection to the blob storage but will then discard it to prevent other people from being able to find it. This URL _won't_ be stored in the [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] database. That means that if you later copy your instance to a sandbox or restore from a backup, then you'll need to re-enter this URL to reestablish the connection to your blob storage in [!include[](../includes/pn-azure-shortest.md)].

1. Save your settings.

1. After a short time, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] will begin to export interaction data as individual files to your blob storage container, where you'll be able to pick it up using [!include[](../includes/pn-power-bi.md)]. You'll also be able to see these files and an associated JSON file in the [!include[](../includes/pn-azure-shortest.md)] Storage Explorer.

## Get the [!include[](../includes/pn-power-bi.md)] template and connect to your Marketing data

Once your [!include[](../includes/pn-azure-blob-storage.md)] is set up and connected to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you're ready to start working in [!include[](../includes/pn-power-bi.md)] to connect to your data sources and design your analytics.

1. If you haven't already, then [download the templates from GitHub](https://github.com/Microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/releases). The following templates are provided:

    - **Dynamics 365 for Marketing template for Power BI**: This template is prepared to connect to your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] data sources, but doesn't include any pre-built analyzers. This is a good place to start when developing custom solutions from scratch.
    - **Email marketing analyzer for Power BI**: This template includes a feature-rich email marketing analyzer that is ready to connect to your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] data sources. It provides a comprehensive report of your email marketing results, including detailed analytics, charts, and views spread across multiple report pages. You can use this template as-is, or as inspiration for designing your own reports.

1. Open your selected template in [!include[](../includes/pn-power-bi-desktop.md)]. If you don't already have [!include[](../includes/pn-power-bi-desktop.md)], you can download it for free from [https://powerbi.microsoft.com/desktop/](https://powerbi.microsoft.com/desktop/).

1. The first time you open the [!include[](../includes/pn-power-bi.md)] template you'll be asked to specify connection strings and credentials to connect to both [!include[](../includes/pn-azure-blob-storage.md)] and to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

    ![The Power BI email marketing analyzer](media/custom-analytics-pbi-connect.png "The Power BI email marketing analyzer")

    - To connect to the [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] database, use the same user credentials that you use to sign into Marketing.
    - You can find connection details for your [!include[](../includes/pn-azure-blob-storage.md)] by using the Storage Explorer app.
    - Specify how many days of interaction data that you want to load (counting back from today).

1. Select **Load** to load the template or analyzer into [!include[](../includes/pn-power-bi.md)].

    > [!NOTE]
    > If you see loading errors the first time you open a template or analyzer, then open the query editor, select a query that is highlighted with a warning icon and then select **Retry** on the notification message bar. Repeat for each query that shows a warning. After all queries have loaded, select **Close & Apply** and the refresh should work from now on.

The email marketing analyzer provides many views, charts, and analytics that marketers should find useful. Use the standard features of the [!include[](../includes/pn-power-bi-desktop.md)] to explore the data sources and analytical displays, and to customize them as required.

![The Power BI email marketing analyzer](media/custom-analytics-pbi-template.png "The Power BI email marketing analyzer")
