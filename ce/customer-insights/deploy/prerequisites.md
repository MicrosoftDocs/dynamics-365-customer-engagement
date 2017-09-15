---
title: Prerequisites
description: This section describes the prerequisites for this version of Customer Insights.
keywords: dynamics 365; customer insights
Applies_to: Dynamics 365 for Customer Insights
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.date: 07/03/2017
ms.topic: get-started-article
ms.service: customer-insights 
ms.assetid: aa7dac0d-a959-46ff-a7e0-dc06a429d419
---

Prerequisites
==========================
[!include[pre release disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

For the current version of [!include[pn-customer-insights](../../includes/pn-customer-insights-full.md)], you should meet the following prerequisites:

1.  **Azure subscription** – If you don’t have an Azure subscription, you can create a free Azure trial account in just a couple of minutes. See the [Free Trial](https://azure.microsoft.com/en-us/free/) article for information about how you can obtain a free trial account. For [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)], we recommend you use your Work credentials for the Azure account.

2. **Data source** - Currently, four data sources ares supported. You can use [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] with multiple data sources.
   - A [!include[pn-crm-online-subsequent](../../includes/pn-crm-online-subsequent.md)] instance. This guide assumes you'll be using a [!include[pn-crm-online-subsequent](../../includes/pn-crm-online-subsequent.md)] instance for your data source. If you don't have a subscription, you can start a free trial. See [Try Dynamics 365 (online)](https://technet.microsoft.com/library/mt772202.aspx).
   - Azure Blob Storage
   - Microsoft Exchange Online
   - Microsoft Social Engagement

   >[!NOTE]
   >You may use an Azure Storage account for storing the input data when using [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)]. If you don’t have an Azure Storage account, see the [Create a Storage account](https://azure.microsoft.com/en-us/documentation/articles/storage-create-storage-account/#create-a-storage-account) article. After you've created the storage account, you will need to obtain the account key used to access the storage. See [View, copy and regenerate storage access keys](https://azure.microsoft.com/en-us/documentation/articles/storage-create-storage-account/#view-copy-and-regenerate-storage-access-keys). <br>
   ><br>
   >If you're using Azure Storage, consider adding the sample data files available from the Microsoft Download Center to your storage. You can use these files to try out [!include[pn-customer-insights](../../includes/pn-customer-insights-short.md)] with sample data to get hands-on experience before using your own data. The sample data is avaliable from the [Microsoft Download Center](http://download.microsoft.com/download/4/E/7/4E75A657-BC9A-4056-83C4-5BC164999142/CustomerInsightsSampleData.zip).


