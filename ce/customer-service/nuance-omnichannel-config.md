---
title: Add an authentication setting for Nuance Gatekeeper 
description: How-to add authentication settings for Nuance Gatekeeper 
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 05/24/2023
ms.custom: bap-template 
---


# Add an authentication setting for Nuance Gatekeeper 

During the on-boarding procedures for your organization in the Private Preview program, you will receive an email with links to a Azure Key Vault that are hosting the Authentication Settings data from Gatekeeper you will need to complete the steps below. 

1. In the Customer Service admin center site map, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.  
1. In **Authentication settings**, select **Manage**. The **Authentication settings** page is displayed. 
1. Select **New Authentication Settings**, and provide the following information on the **Add authentication setting** page: 
    - **Name**: Enter a name for the authentication setting. 
    - **Channel type**: Accept the default value or change to a required value. 
    - **Authentication type**: Gatekeeper Biometric Authentication is selected and not available for an edit. 
1. Select **Next**. 
1. On the **Details** page, enter the following information: 

   - **Endpoint region**: Is selected as US and not editable.
   - **Client ID**: The Nuance Gatekeeper client ID. 
   - **Client Secret**: The Nuance Gatekeeper client secret. 
   - **Scope ID**: The Nuance Gatekeeper scope ID. 
   - **Config Set ID**: The Nuance Gatekeeper config set ID. 
1. Save and close. 

Once you click save and close, components will be provisioned and your settings tested. Errors at this step means either the settings are not correct, or that you ACS resources are running in a different Azure tentant from your Dynamics 365 environment. 

## Add a workstream or select an existing workstream and configure Authentication 

1. Perform the steps listed at [Create and manage workstreams](create-workstreams.md) to create a voice workstream. 
1. Edit the phone number setting of the voice workstream, and select the **Behaviors** tab. 
1. Scroll down and turn on the toggle for **Authentication (preview)**. 
1. Select an authentication option in **Authentication setting** and select **Save**. 

## Next steps


