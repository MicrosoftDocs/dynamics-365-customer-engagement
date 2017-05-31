---
title: "Integrate Dynamics 365 for Project Service Automation with a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: e37279ea-6e6d-4c48-9350-082cae96a0c0
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Project Service Automation integration
[comment]: <> (Add See Also links)
The Project Service Automation (PSA) solution for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] can now be installed on a Partner Portal (PSA for [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] and Partner Portal Solutions must be installed first). With this solution installed customers and partners will be able to view projects and confirmed bookable resources. Customers will also be able to approve quotes, view invoices, and view contract/order forms.

## View projects on the partner portal

Both Customers and Partners can view projects pertaining to them on the Partner Portal. Customers can view Active and Closed Projects associated with their organization. Partners can view projects when a Bookable Resource from their organization is associated with the projected. In both cases the User must have an appropriate PSA-specific Web Roles (PSA Customer Approver/Reviewer or PSA Partner Approver/Reviewer). After logging in to the portal, the customer or partner can view the project by going to **Customer Projects**. From here they can see basic information for each project and choose to view by Active Projects, Closed Projects, or All Projects.

![View projects in a partner portal](media/view-projects-partner-portal.png "View projects in a partner portal")

## View and approve project quotes on the partner portal

Customers can view and approve project quotes created in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] that are associated with their organization. After logging into the portal, the customer navigates to **Project Service Automation** &gt; **Quotes** then change the filer to **Last 7 Days**. From here the customer will be shown pending quotes along with basic details like Status and Total Amount. The Customer can now click on a quote for more detailed information and the ability to approve or reject the quote with the **Approve Quote** or **Reject Quote** buttons near the bottom of the project.

## View project invoices on the partner portal

Customers can view final versions of Project Invoices on the partner portal after the invoice has been approved in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] and the **Visible to customer** checkbox has been selected. To view an invoice, the customer must sign in to the partner portal and navigate to **Partner Service Automation** &gt; **Invoices.** Here a customer will be presented with basic information and can click on an invoice for more details.

![View invoices in a partner portal](media/view-invoices-partner-portal.png "View invoices in a partner portal")

## View project contracts and order forms on the partner portal

Customers can view final versions of Project Contracts or Orders on the partner portal after a project contract has been opened in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] with the **Visible to customer** checkbox selected on the contract. After signing in to the partner portal, the customer navigates to **Project Service Automation** &gt; **Contracts**. Here customers can see a sorted list of contracts with some basic information, or select a contract for more details.
![View contracts in a partner portal](media/view-contracts-partner-portal.png "View contracts in a partner portal")

![View quotes in a partner portal](media/view-quotes-partner-portal.png "View quotes in a partner portal")  

## View confirmed, bookable resources by project and role on the partner portal

Both Customers and Partners can view bookable resources on the partner portal following the same process. After signing in to the partner portal, they must navigate to **Project Service Automation** &gt; **Customer Resources**. Here Customers and Partners can see list of resources with their role, booked hours, and other basic information. By selecting a resource, they will be able to see what tasks that resource has been assigned to.

![View customer resources in a partner portal](media/view-customer-resources-partner-portal.png "View customer resources in a partner portal")

### See Also