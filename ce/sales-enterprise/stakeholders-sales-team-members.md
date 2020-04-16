---
title: "How are stakeholders and sales team members tracked for opportunities? (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how stakeholders and sales team members for opportunities are tracked in Dynamics 365 Sales."
ms.date: 04/20/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# How are stakeholders and sales team members tracked for opportunities?

When you're working on an opportunity, you need to track who the stakeholders are and also the team members who are working with you on the opportunity. The Stakeholders and Sales Team subgrid on the out-of-the-box Opportunity form lets you do that.  

## Stakeholder subgrid

The **Stakeholders** subgrid uses Connections to associate contact records as stakeholders with the opportunity. For more information, see [Create connections to define and view relationships between records](/dynamics365/customerengagement/on-premises/basics/create-connections-view-relationships-between-records).
    
You can add a contact as a stakeholder to the opportunity using the "+New Connection" subgrid button. This creates a connection record between the opportunity and the contact using the "Stakeholder" connection role. For more information, see [Configure connection roles](/powerapps/maker/common-data-service/configure-connection-roles). You can change the connection role to any other applicable stakeholder connection role by opening the record and changing the **As this role** field on the connection record. Other out-of-the-box connection roles configured under the 'Stakeholder' connection role category are Champion, Decision Maker, End User, Economic Buyer,  Influencer, and Technical Buyer.

> [!NOTE]
> The **Stakeholders** subgrid on the Opportunity form shows only those connection records whose connection role's category is Stakeholder.

## Sales team subgrid

You can add existing users as sales team members using the Sales team subgrid. The **Sales team** subgrid also uses Connections to associate users with the opportunity in different sales member roles. Similar to adding a stakeholder, you can add an existing user as a Sales team member by using "+ New Connection" button. You can change the connection role to any other applicable sales team connection role by opening the record and changing the **As this role** field on the connection record. Other out-of-the-box connection roles configured under the 'Sales Team' connection role category are Delivery Professional, Account Manager, Territory Manager, Service Professional, Industry Expert, and Technical Sales Professional.
    
> [!NOTE]
>  The **Sales team** subgrid shows only those connection records whose connection role's category is Sales Team.
    
Dynamics 365 Sales uses the Opportunity Sales Team Template to provide access to the opportunity record to all the users connected under the "Sales Team" connection role category. A salesperson who may not have access to a given opportunity record by his/her assigned security role privileges can still get access when added as a Sales team member from this sub grid. This allows the sales team member users to have access to and work with opportunity record in Dynamics 365 on a record basis. Similarly, when an existing sales team member is deleted from the subgrid, the access gained to the opportunity record via the access team template is also removed. 

### See also

[Create or edit opportunities](create-edit-opportunity-sales.md)
