---
title: "Define alternate keys to reference Dynamics 365 Customer Engagement records | MicrosoftDocs"
ms.custom: ""
ms.date: 10/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "rdubois-msft"
ms.assetid: 29e53691-0b18-4fde-a1d0-7490aa227898
caps.latest.revision: 10
ms.author: "rdubois"
manager: "brycho"
---
# Define alternate keys to reference Dynamics 365 records

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

With *alternate keys*, you can assure an efficient and accurate way of integrating data into [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] from external systems. It’s especially important in cases when an external system doesn’t store the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record IDs (GUIDs) that uniquely identify records. The alternate keys are not GUIDs and you can use them to uniquely identify the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records. You must give an alternate key a unique name. You can use one or more entity fields to define the key. For example, to identify an account record with an alternate key, you can use the account name and the account number. You can define alternate keys in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application without writing code, or you can define them programmatically. Note that while you can define the alternate keys in the user interface (UI), they can only be used programmatically, in code.  
  
 Some of the benefits of the alternate keys feature include:  
  
-   Faster lookup of the records.  
  
-   More robust bulk data operations, especially in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)].  
  
-   Simplified programming with data imported from external systems without [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record IDs.  
  
To learn more about alternate keys programmability, see:   
[Define alternate keys for an entity](../developer/define-alternate-keys-entity.md)  
[Use an alternate key to create a record](../developer/use-alternate-key-create-record.md) 
  
## Define alternate keys  
1. Go to [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]. 
2. Choose **Customize the System** > **Components** > **Entities** > **Entity \<X>** > **Keys**. 
3. Choose **New**. 
4. On the form, fill in the required fields (**Display Name** and **Name**) and then choose and add the fields to the key. 
5. Save the key. 

The example below uses the Account Number field in the alternate key definition.  
  
 ![Define alternate key for the account entity](../customize/media/cust-alternatekeys-accountkey.PNG "Define alternate key for the account entity")  
  
> [!NOTE]
>  You can define up to five different keys for an entity.  
  
### See also  

 [Create and edit web resources](../customize/create-edit-web-resources.md)   
 [Define alternate keys for an entity (Developer Guide)](../developer/define-alternate-keys-entity.md)
 [Use an alternate key to create a record (Developer Guide)](../developer/use-alternate-key-create-record.md)
