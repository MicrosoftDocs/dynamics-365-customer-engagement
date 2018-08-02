---
title: "Create connections to define relationships between records (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 3cd98c0b-0599-4d96-8e9a-095e2d528a9c
caps.latest.revision: 29
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Create connections to define and view relationships between records

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

In [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you can create and view the relationships between records for many entities using **Connect**. Connections enable you to easily associate users, contacts, quotes, sales orders, and many other entity records with each other. When you open a record and select **Connections**, you can view all of the connections between it and other records.  
  
 When you create a connection, you assign it a role. There are many different roles you can use to identify your connections, such as Account Manager or Colleague. Connection roles define how records are related to you, to your organization, or to one another, such as manager to employee. There are three types of connection roles: business, family, and social. Your system administrator can add new connection roles.  
  
<a name="BKMK_Createconnection"></a>   
## Create a connection  
  
1.  Open a record, and then on the command bar, click **Connect** > **To Another**.  
  
     The record you start with is known as the source record.  
  
2.  In the **New Connection** dialog box, enter a **Name** and **As this role** to identify the connection role for the record you want to connect to, called the target record. Optionally, enter a description.  
  
     The role of the target record can be the same as the source record, it can be different, or you can leave the target record role blank.  
  
3.  If needed, you can select a different owner for the connection. Select **Details**, and then fill in the fields.  
  
4.  Click **Save**, **Save and Close**, or **Save & New** to save the newly created connection and open the form to create another connection.  
  
<a name="BKMK_Viewconnections"></a>   
## View connections for a record  
  
1. Open the record that you want to view connections for.  
  
2. To view all the connections, select the related records drop-down menu next to the record name, and then click **Connections**.  
  
   ![Select related records dropdown to view Connection](../admin/media/select-related-records-view-connection.PNG "Select related records dropdown to view Connection")  
  
<a name="BKMK_Deactivateordelete"></a>   
## Deactivate or delete a connection  
 If you no longer need a connection for a record, you can deactivate it or delete it to permanently remove the connection.  
  
1.  Open the record that you want to deactivate or delete the connection from.  
  
2.  Select the related records drop-down menu next to the record name, and then click **Connections**.  
  
3.  Select the connection you want to deactivate or delete, and then click **Deactivate** or **Delete**.  
  
### See also  
 [Account relationships](../basics/account-relationships-hierarchical-view.md)
