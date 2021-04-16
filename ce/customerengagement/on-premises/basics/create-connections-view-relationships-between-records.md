---
title: "Create connections to define relationships between records (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: ""
keywords: 
ms.date: 05/05/2020
ms.service: crm-online
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 3cd98c0b-0599-4d96-8e9a-095e2d528a9c
author: jimholtz
ms.author: jimholtz
manager: brycho
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 29
---

# Create connections to define and view relationships between records

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Add a connection role to link records to each other](/powerapps/user/add-connection-role)

In Dynamics 365 Customer Engagement (on-premises), you can create and view the relationships between records for many entities using **Connect**. Connections enable you to easily associate users, contacts, quotes, sales orders, and many other entity records with each other. When you open a record and select **Connections**, you can view all of the connections between it and other records.  
  
 When you create a connection, you assign it a role. There are many different roles you can use to identify your connections, such as Account Manager or Colleague. Connection roles define how records are related to you, to your organization, or to one another, such as manager to employee. There are three types of connection roles: business, family, and social. Your system administrator can add new connection roles.  
  
<a name="BKMK_Createconnection"></a>   
## Create a connection  
  
1.  Open a record, and then on the command bar, select **Connect** > **To Another**.  
  
     The record you start with is known as the source record.  
  
2.  In the **New Connection** dialog box, enter a **Name** and **As this role** to identify the connection role for the record you want to connect to, called the target record. Optionally, enter a description.  
  
     The role of the target record can be the same as the source record, it can be different, or you can leave the target record role blank.  
  
3.  If needed, you can select a different owner for the connection. Select **Details**, and then fill in the fields.  
  
4.  Select **Save**, **Save and Close**, or **Save & New** to save the newly created connection and open the form to create another connection.  
  
<a name="BKMK_Viewconnections"></a>   
## View connections for a record  
  
1. Open the record that you want to view connections for.  
  
2. To view all the connections, select the related records drop-down menu next to the record name, and then select **Connections**.  
  
   ![Select related records dropdown to view Connection](../basics/media/select-related-records-view-connection.png "Select related records dropdown to view Connection")  
  
<a name="BKMK_Deactivateordelete"></a>   
## Deactivate or delete a connection  
 If you no longer need a connection for a record, you can deactivate it or delete it to permanently remove the connection.  
  
1.  Open the record that you want to deactivate or delete the connection from.  
  
2.  Select the related records drop-down menu next to the record name, and then select **Connections**.  
  
3.  Select the connection you want to deactivate or delete, and then select **Deactivate** or **Delete**.  
  



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
