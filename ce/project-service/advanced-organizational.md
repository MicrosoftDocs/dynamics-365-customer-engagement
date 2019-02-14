---
title: Organizational units in Project Service 
description: This topic provides information about organizational units in Project Service Automation (PSA).
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 2/14/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Organizational units in Project Service

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In Project Service Automation (PSA), an organizational unit is a distinct group or division in a professional services company that employs billable resources with cost rates.

For services firms that employ technical resources in various practices or business lines, the cost to fill a role in one practice area or business line may be completely different from another practice area or business line. The organizational unit concept is designed to help with this need by providing a way to group a set of billable roles in a division of a company that has a distinct cost structure for these roles.

## Key attributes and associations of organizational units

An organizational unit in PSA has a specific currency and cost price lists.

The currency of an organizational unit is the primary currency used to track costs.

There can be one or more cost price lists attached to an organizational unit. PSA places the following restrictions on price lists that can be attached to an organizational unit:

- Price lists must be in the currency of the organizational unit
- Price lists must be of cost context

In addition to having a currency and cost price list, the organizational unit attribute is also on the **Resource** entity. Each **Resource** can be assigned to one organizational unit.

## Roles of organizational units

The organizational unit plays two roles in PSA:

- **Contracting unit**: The organizational unit represents the division or group of the company that is primarily responsible for winning the sale and managing the delivery of the work and services to the customer. The contracting unit is identified by the field **Contracting Unit** under the **Opportunity**, **Quote**, **Project Contract**, and **Project** headers. 
- **Resourcing Unit**: The organizational unit that a resource belongs to or is assigned to. This organizational unit may provide its resources for certain roles on SOWs and projects owned by the contracting unit.

> ![Estimates tab](media/advanced-1.png)

## Organizational unit FAQs

Here are some of the most frequently asked questions about organizational unit entities.

### How does the organizational unit entity in PSA relate to the organization entity that already exists in Dynamics 365?

The organization entity in Dynamics 365 represents the name of a global Dynamics 365 instance. This is usually the name of the global enterprise.

The organizational unit is a group or division within the global enterprise that has a set of roles and a distinct cost price list for these roles that is different from other divisions in the company.

When PSA is installed, a default organizational unit is created based on the organization. All existing resources are assigned to the default organizational unit. Any new active directory users or resources that are imported into Dynamics 365 are assigned to the default organizational unit in PSA by the user import process.
 
### How is the organizational unit entity different from the business unit entity?

The business unit entity in Dynamics 365 is designed as a security construct. Associating a user to a business unit will directly determine what entities and entity records the user has access to. It also determines which permissions (Create, Read, Write, Delete, Append, Append To, Assign, and Share) the user has on those entity records.

The organizational unit entity represents a unit or division of the company that has distinct cost rates for employees that are assigned to it. Associating a resource to an organizational unit will determine its cost to a project engagement. 
When you implement Dynamics 365, optimize security authorization for the hierarchy of business units and the assignment of users to business units. Assign all users who typically need to access the same set of records to the same business unit. The organizational unit has no impact on security authorization or access.

#### Example of organizational unit entity

Contoso, Ltd. has a thriving Microsoft technology practice. Prakash and Tricia are both C# developers, but Tricia is in the United States and Prakash is in India. Most of the project engagements require resources from Contoso India and Contoso US, and Prakash and Tricia require the same level of security access to projects in this practice area. However, there is a significant difference in the costs of developers from Contoso India and developers from Contoso US.

An optimal way to design for this using Dynamics 365 and PSA is to:

1. Create a Microsoft technology practice as a business unit and associate Prakash and Tricia with it. This will ensure that they both get the same level of security access to any projects in that practice area. They will be able to check progress and report time, expenses, and task updates. 
2. Create two organizational units to make sure that the cost to project is correctly reflected. 
3. Associate Tricia to Contoso U.S. and Prakash to Contoso India.
4. Assign appropriate cost price lists to both organizational units. This will ensure that the costs recorded on the project for Prakash and Tricia accurately reflect the difference in costs between Contoso U.S. and Contoso India.

### Are organizational units related to sales territories in Dynamics 365?

There is no association or relationship between sales territories and organizational units. A sales territory is typically a geographical area in which sales are affected. Each sales territory can have a sales price list associated to it. An organizational unit is an internal part or division within the company that tracks costs for a set of roles that it sells to other divisions or external customers.

#### Example of organizational units and sales territories

Contoso, Ltd. has two development centers, Contoso US and Contoso India. Costs of resources are vastly different across these two operating centers.

Contoso sells its IT services in many markets internationally, such as Latin America, North America, Asia-Pacific, Western Europe, and the Middle East. Bill rates for the same project roles could vary vastly across each of these markets.

Contoso US and Contoso India should be set up as organizational units with their own specific cost price list. Asia-Pacific, Latin America, North America, Western Europe, and the Middle East should each be set up as sales territories with their specific sales price lists. 

### Why is there a restriction to associate price lists of cost context to organizational units? 

Sales pricing is usually unique to the geographical area or to the markets in which services are sold. Internal divisions of a company usually do not have their own sales pricing for the same type of services. Internal divisions, however, have varied COGS depending on the skills of the people they employ and the labor conditions of the region in which they operate. Since organizational units are modeled as internal divisions of a company, they can have only cost price lists.

### Why can’t we associate sales price lists to organizational units?

In PSA, sales price lists can be associated to customers and sales territories. Transactional entities like **Opportunity**, **Quote**, **Project Contract**, and **Project** use sales price lists attached to the customer account or the sales territory to determine bill rates and potential revenue on the project engagement. Cost price lists are associated to organizational units. 
Transactional entities like **Opportunity**, **Quote**, **Project Contract**, and **Project** use cost price lists attached to the contracting unit to determine costs to project engagement.

### Are organizational units hierarchical in PSA?

No. In the current release of PSA, organizational units are not hierarchical. This means that you can’t:

- Configure a pattern for defaulting cost prices that traverses up a hierarchy. 
- Report revenue or cost rolled up at different levels of the organizational unit hierarchy.

### We are a big multinational firm with a complex, multilevel hierarchy of cost centers, divisions, and billing offices. How can we make the best use of the organizational unit concept in this version of the Project Service app?

When you have a complex hierarchy of organizational units, set up the leaf nodes of that list as distinct organizational units.
The following example shows a common hierarchy:

Contoso India
- SAP Practice 
	-Technical Consultants 
	- Functional Consultants 
	- Microsoft Technology Practice 
Technical Consultants
	- Functional Consultants 
Contoso US
	- SAP Practice 
		- Technical Consultants 
		- Functional Consultants 
Microsoft Technology Practice 
	- Technical Consultants 
	- Functional Consultants 
 
If your hierarchy is similar, you must set it up as a flat list such as this:
- Contoso India - SAP Practice - Technical Consultants 
- Contoso India - SAP Practice - Functional Consultants 	  
- Contoso India - Microsoft Technology Practice Functional Consultants 
- Contoso India - Microsoft Technology Practice Functional Consultants 
- Contoso US - SAP Practice - Technical Consultants  
- Contoso US - SAP Practice - Functional Consultants  
- Contoso US - Microsoft Technology Practice - Technical Consultants 
- Contoso US - Microsoft Technology Practice - Functional Consultants

### We are a small professional services firm and only operate as one division. How can we make the best use of the organizational unit concept in this version of the Project Service app?

You don’t have to set up any organizational units if your company operates as one unit with one cost price list. During PSA installation, Dynamics 365 creates one default organizational unit with the same name as the organization. All users are assigned to this organizational unit by default. This single unit is the default wherever the system requires the selection of an organizational unit.

### When a project is created from a quote or project contract line, the default contracting unit comes from the quote or project contract. If a project is created before the creation of sales entities like quote or project contract, what is the default contracting unit?

When a project is created on its own, the default contracting unit of the project is based on the user creating it. The user creating it is also the default project manager. If the project was mapped to a sales entity like a quote or project contract, the contracting unit on the project re-defaults based on the sales entity. This could result in a recalculation of project estimates because the cost price list is used to calculate the cost estimate changes if there is a change in contracting unit. The sales price list is also used to calculate the sales estimates that will be changed to be in sync with the project price list on the quote.

The **Contracting Unit** and **Currency** fields on the project are locked for editing since these are required to be in sync with the values on the sales entity (quote or contract) that the project maps to.
