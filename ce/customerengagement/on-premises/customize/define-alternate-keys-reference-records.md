---
title: "Define alternate keys to reference records | MicrosoftDocs"
description: "Learn how to define alternate keys that can be used to reference records"
ms.custom: 
ms.date: 04/03/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 29e53691-0b18-4fde-a1d0-7490aa227898
caps.latest.revision: 10
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Define alternate keys to reference records

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Define alternate keys using Power Apps portal](/powerapps/maker/common-data-service/define-alternate-keys-portal)

With *alternate keys*, you can assure an efficient and accurate way of integrating data from external systems. It’s especially important in cases when an external system doesn’t store the record IDs (GUIDs) that uniquely identify records. The alternate keys are not GUIDs and you can use them to uniquely identify records. You must give an alternate key a unique name. You can use one or more entity fields to define the key. For example, to identify an account record with an alternate key, you can use the account name and the account number. You can define alternate keys without writing code, or you can define them programmatically. Note that while you can define alternate keys in the user interface (UI), they can only be used programmatically, in code.  
  
 Some of the benefits of the alternate keys feature include:  
  
-   Faster lookup of the records.  
  
-   More robust bulk data operations.  
  
-   Simplified programming with data imported from external systems without record IDs.  

> [!IMPORTANT]
>  You can't use a field that is in use by existing records as an alternate key. This will result in a duplicate records error.
  
To learn more about alternate keys programmability, see:   
[Define alternate keys for an entity](../developer/define-alternate-keys-entity.md)  
[Use an alternate key to create a record](../developer/use-alternate-key-create-record.md) 
  
## Define alternate keys  
1. Open solution explorer. 
2. Go to **Components** > **Entities** > **Entity \<X>** > **Keys**. 
3. Select **New**. 
4. On the form, fill in the required fields (**Display Name** and **Name**) and then select and add the fields to the key. 
5. Save the key. 

The example below uses the Account Number field in the alternate key definition.  
  
 ![Define alternate key for the account entity](../customize/media/cust-alternatekeys-accountkey.PNG "Define alternate key for the account entity")  
  
> [!NOTE]
>  You can define up to five different keys for an entity.  
  
### See also  

 [Create and edit web resources](../customize/create-edit-web-resources.md)   
 [Define alternate keys for an entity (Developer Guide)](../developer/define-alternate-keys-entity.md)
 [Use an alternate key to create a record (Developer Guide)](../developer/use-alternate-key-create-record.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]