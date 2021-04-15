---
title: "Security Roles for Sales (Dynamics 365 Sales) | MicrosoftDocs"
description: "Predefined Security roles define permissions and access levels specific to different sales personas. Assign users to appropriate security roles to grant them adequate access to the system."
ms.date: 04/16/2021
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-opportunity
  - D365-UI-*
  - Customer Engagement
  - Dynamics 365
  - Sales
---
# Security Roles

Security roles control a user's access to data through a set of access levels and permissions. The combination of access levels and permissions that are included in a specific security role defines limits on the user's view of data and on the user's interactions with that data.

## Permissions

Permissions define the actions that a user is permitted to do on an entity. The following permissions are supported:

| **Permission** | **Allowed Action** |
|-------------------------|-------------------------|
| Create | Allows the user to create a record. |
| Read | Allows the user to view a record. |
| Write | Allows the user to update an existing record. |
| Delete | Allows the user to delete a record. |
| Append | Allows the user to associate another entity with a record, acting as a lookup field. The user should have the **Append to** permission on the entity being associated. For example, if an opportunity record has the contact field as a lookup, the users must have a security role that has Append permissions for Opportunities and Append to permissions for Contacts. |
| Append to | Allows the user to use an entity as a lookup field in another entity. |
| Assign | Allows the user to change the owner of a record. |
| Share | Allows the user to share a record with another user. The user can grant specific permissions while sharing the record. |

## Access Levels

Access levels define the scope of permissions. For example, a Sales Vice President would have a broader scope compared to a salesperson. The Sales VP may need access to the data of the entire Business Unit, whereas a Salesperson’s access could just be limited to their own team. The following access levels are supported:

| **Access Level** | **Scope of Permissions** |
|-------------------------|-------------------------|
| None | No permissions given. |
| User | Access to the records that are owned either by the user or the team the user belongs to, or the records shared with the user |
| Business Unit | Access to the records that are owned by the business unit that the user belongs to. |
| Parent: Child Business Units | Access to the records of the business unit that the user belongs to and all of its child business units |
| Organization | Access to all the records in Dynamics 365 for the entire organization. |

## Predefined Security Roles for Sales

The predefined security roles for Sales include permissions and access levels that the default sales personas will need. For example, the Sales Manager and Salesperson security roles can be associated with the respective users in your organization. As a system administrator, you can verify the permissions and access levels granted for each role and modify it to suit your needs. For more information, see [Create or edit a security role](/power-platform/admin/create-edit-security-role).

| **Security Roles** | **Who needs it?** | **Access Granted** |
|-------------------------|-------------------------|-------------------------|
| **Sales** |  |  |
| Sales Manager | Users who manage a team of sellers and are responsible for the team's performance. They are also responsible for creating and managing product SKUs, setting sales targets, and projecting sales forecasts. | Create product families and bundles, create, retire and clone products, translate product name and properties Publish a product or bundle to make it available for selling, Define related products to increase sales, Revise products,, create sales literature, Analyze sales data, Configure sales forecasts, project forecasts, Adjust forecast values , define and track goals for the team. |
| Sales team member | Users whose jobs aren't necessarily tied to a function but who still need to use the basic functionality of a line-of-business system. This license gives users lightweight access through designated scenarios built into the Team Member experience. | Access to the Sales Team Member App.</br><ul></br><li>Customer management: work with contacts or see accounts.</li></br><li>Lead and opportunity management: see leads or opportunities linked with accounts or contacts, or see other sales-related data.</li></br><li>Add notes and activities, such as tasks.</li></br></ul> |
| Salesperson | Sellers who work on opportunities, quotes, orders, and invoices. | Access to everything from lead to order – Lead, Opportunities, Quote, Order, Invoice.</br>Create accounts and contacts, and track goals |
| Vice President of Sales | Users who typically manage the sales organization for a specific business unit or the entire organization. | Same permissions as the Sales Manager, except that their scope of access will be at the business unit or organization level. |
|  |  |  |
|  |  |  |
| **Forecast** |  |  |
| Forecast Manager | Sales manager or an equivalent role who is responsible for sales forecasting  | Configure, clone, deactivate, adjust, or delete a forecast. |
| Forecast user | Any user in the organization who needs access to the forecast data for tracking and analysis  | View forecast and drill-down forecast data |
|  |  |  |
| **Playbook** |  |  |
| Playbook Manager | Sales manager or an equivalent role who enforces best practices for playbooks | Create playbook categories and playbook templates, and add documents to the playbook template. |
| Playbook User | Sales representatives who create and launch playbooks | Launch playbooks in the context of an entity, mark a playbook as completed, and track playbook activities . |
|  |  |  |
| **System Roles** |  |  |
| System Administrator | Users who need to configure the sales settings and administer the system. | System administrators are super users of the systems; they have access to the entire system. They can add users, assign roles, elevate roles, and configure the system as per the organization's needs. |
| System Customizer | Users who need to customize the apps, forms, or views. They have access to most of the entities, by default. A system administrator can grant or revoke access depending on the scope of customization. | Full access to most of the entities so that they can customize apps, views, forms, business process flows and so on. |
|  |  |  |

## Assign Security Roles to a User

Associate one or more security roles to a user depending on their roles and responsibilities. For example, if a Sales Manager is also
responsible for enforcing best practices for Playbooks, assign the Sales Manager and Playbook Manager security roles to that user.

**Follow these steps:**

1. From the Sales Hub app, select the Settings icon in the top-right
   corner and select **Advanced Settings**.

2. Select **Settings** in the Business Management interface and
   navigate to **System, Security**.

3. Select **Users** and open the user account to which you want to
   assign the role.

4. Select **Manage Roles** and choose the roles that you want to assign to the user.

5. Notify the user and have them check their permissions.
