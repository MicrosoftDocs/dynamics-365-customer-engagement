---
title: "How are stakeholders and sales team members tracked for opportunities? (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how stakeholders and sales team members for opportunities are tracked in Dynamics 365 Sales."
ms.date: 04/22/2020
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
---

# How are stakeholders and sales team members tracked for opportunities?

When you're working on an opportunity, you need to track who the stakeholders are and also the team members who are working with you on the opportunity. The Stakeholders and Sales Team subgrid on the out-of-the-box Opportunity form lets you do that.  

## Stakeholder subgrid

The **Stakeholders** subgrid uses connections to associate contact records as stakeholders with the opportunity. More information: [Create connections to define and view relationships between records](/dynamics365/customerengagement/on-premises/basics/create-connections-view-relationships-between-records).

You can add a contact as a stakeholder to the opportunity by selecting **+New Connection** on the subgrid. This creates a connection record between the opportunity and the contact by using the **Stakeholder** connection role. For more information, see [Configure connection roles](/powerapps/maker/common-data-service/configure-connection-roles). You can change the connection role to any other applicable stakeholder connection role by opening the record and changing the **As this role** field on the connection record. Other out-of-the-box connection roles configured under the **Stakeholder** connection role category are Champion, Decision Maker, End User, Economic Buyer, Influencer, and Technical Buyer.

> [!NOTE]
> The **Stakeholders** subgrid on the Opportunity form only shows connections that have a connection role category of **Stakeholder**.

## Sales team subgrid

You can add existing users as sales team members by using the **Sales team** subgrid. The **Sales team** subgrid also uses connections to associate users with the opportunity in different sales member roles. Similar to adding a stakeholder, you can add an existing user as a sales team member by using **+ New Connection**. You can change the connection role to any other applicable sales team connection role by opening the record and changing the **As this role** field on the connection record. Other out-of-the-box connection roles configured under the **Sales team** connection role category are Delivery Professional, Account Manager, Territory Manager, Service Professional, Industry Expert, and Technical Sales Professional.
    
> [!NOTE]
>  The **Sales team** subgrid only shows connections that have a connection role category of **Sales team**.
    
Dynamics 365 Sales uses the Opportunity Sales Access Team template to provide access to the opportunity record to all the users connected under the **Sales team** connection role category. A salesperson who might not have access to a given opportunity record by their assigned security role privileges can still get access when added as a sales team member from this subgrid. This allows the sales team member users to access and work with the opportunity record in Dynamics 365 on a per-record basis. Similarly, when an existing sales team member is deleted from the subgrid, the access to the opportunity record granted via the access team template is also removed. More information: [Share records using Access Team](/powerapps/user/access-team)

### See also

[Create or edit opportunities](create-edit-opportunity-sales.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
