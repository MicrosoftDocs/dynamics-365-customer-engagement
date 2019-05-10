---
title: "Hosting your custom event website on Azure | MicrosoftDocs"
description: "Step-by-step tutorial on how to host your custom event website on Azure"
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 03/13/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
author: Nkrb
ms.author: nabuthuk
manager: kvivek
---

# Host your custom event website on Azure

This topic will walk you through how to host your custom event portal on Azure. You can either build your frontend or customize the provided demo portal build using the [Angular](https://angular.io/) framework. More information [Build and host custom event portal](event-management-web-application.md)

## Prerequisites

1. Download the [source code]() to customize the provided demo portal.
2. Install [Node.js] version 10.x or higher.
3. Download the [Azure storage explorer](https://docs.microsoft.com/en-us/azure/vs-azure-tools-storage-manage-with-storage-explorer?tabs=windows)

## Step 1:  Create an Azure storage account

To create an Azure storage account, follow the steps below:

1. Login into [Azure portal](https://portal.azure.com) and click on **Sign in**, if you dont have an Azure account, register for it.

2. Click on **Storage accounts** and click on **Add** to create a new storage account.

3. In the **Subscription and Resource group** dropdown, select your subscription from the existing list of subscriptions. When you select an existing **Subscription**, the **resource group** field displays the available resource groups. If you don't have an existing one, create a new **Resource group**.

4. Enter the **Storage account name**and also select the **Location**.

5. Set the values as shown in the screenshot and click on **Review + create**

   > [!NOTE]
   > You can modify all the settings that suits to your needs.

6. Review your configuration and click on **Save**

### Enabling static website hosting

1. Select the newly created **Storage account** and click on **Static website**

2. Enable the **Static website** by flipping the switch and configure **Index document name** and **Error document path** to use **Index.html**

3. Click on **Save**. A new field **Primary endpoint** is shown. Copy the URL from the **Primary endpoint** field. This is the URL from which you reach your custom event website.

## Step 2: Create a web application token

To use event management public API, you need a web application token. The web application token is used to control API requests that are associated with your organization.

1. Open your Dynamics 365 and navigate to Event Management
2. Click on the dropdown and select **Settings**
3. Click on the **Web applications**
4. Click on the **New** to create a new web application token.
5. Enter details in the **Name** field.
6. For the **Origin** field enter the **Primary endpoint** value that you got while enabling the static website.
7. Click on **Save**. You will get the web application token and the API endpoint. 

## Step 3: Create environment.ts file

1. Open the (in the prerequisites downloaded) source code with your favorite IDE (we recommend Visual Studio Code).  
2. Navigate to `src/environments/` directory. 
3. Open the file `environment.selfhosted.ts`. This file contains all the configuration settings for your event website. 
4. Enter the `Endpoint` value from the Web Application setting in the `apiEndpoint` field. Append `EvtMgmt/api/v2.0/` to the value. 
5. Enter the generated `Token` from Web Application setting in the `emApplicationtoken` field and save the file. 
6. Open a terminal in the root of your custom event website directory and type in 
    ```CLI 
     ng build --prod --output-hashing none --configuration self-hosted 
    ``` 
7. This will build the website. You can find the generated files in `dist\ClientApp`. 

## Upload your custom event website

1. Open **Microsoft Azure Storage Explorer** 
2. Sign in with your Azure account. 
3. Select your **Storage account** 
4. Select the **$web blob container**
5. Drag all files that you have generated before (located in `dist/ClientApp` directory) in the `$web` blob container. 