---
title: "Create a custom channel (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "A custom channel contains custom entities, workflow or plug-in containing your custom logic, and couple of web resources that help surface the custom channel as a “tile” in the customer journey designer."
ms.custom: ""
ms.date: 12/15/2017
ms.service: "crm-online"
ms.technology: 
  - "marketing"
ms.topic: "conceptual"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 30a97860-1369-400b-8931-5d070daea4f9
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Create a custom channel

Creating a custom channel for customer journeys in Dynamics 365 for Marketing can be divided into four steps.

## Step 1: Create the required entities and forms

You might want to create custom entities and forms to store and display information about your custom channel. You might also want to build a configuration page to help users connect to an external service that your custom channel interacts with. Finally, you could build some dashboards to display some analytics information.

More information:
- [Create or edit entities (record types)](../../customize/create-edit-entities.md)
- [Create and design forms](../../customize/create-design-forms.md)
- [Create or edit dashboards](../../customize/create-edit-dashboards.md)

## Step 2: Create a workflow or plug-in to implement your custom logic

Partners can create a workflow or plug-in to implement their custom logic. The workflow or the plug-in should be configured to:

a. Execute on the creation of an instance of the Custom Channel Activity (msdyncrm_customerjourneycustomchannelactivity) entity. An instance of this entity is created whenever a contact, which has the compliance field set to allow use of custom channels, goes through the customer journey. For information about the compliance field, see Define the Tile XML file.
b. Interact with the external service to perform the required operations. For example, in case of a Special custom channel, your custom code should be able to send messages using the external service provider and receive responses or feedback, if any.
c. Call the **Custom Channel Activity Create Interaction** action to send the customer journey feedback to Dynamics 365 for Customer Insights for further processing.


## Step 3: Configure the tile for custom channel

## Step 4: Test your custom channel tile

To make your custom channel tile visible in the customer journey designer: 

1.  Create a solution. More information: Create solution 
  
### See also  
 [Administrator Guide (Marketing)](../../marketing/admin-guide.md)
   
 [User Guide (Marketing)](../../marketing/user-guide.md)   