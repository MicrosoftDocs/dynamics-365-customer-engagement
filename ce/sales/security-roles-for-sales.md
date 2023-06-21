---
title: "Predefined security roles for Sales (Dynamics 365 Sales) | MicrosoftDocs"
description: "Predefined security roles define permissions and access levels specific to different sales personas. Assign users to appropriate security roles to grant them adequate access to the system."
ms.date: 09/12/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---
# Predefined security roles for Sales

Predefined security roles define permissions and access levels specific to different sales personas. [Assign users to appropriate security roles](#assign-security-roles-to-users) to grant them adequate access to the system.

## Predefined security roles

Security roles control users' access to data through a set of access levels and permissions. The combination of access levels and permissions that are included in a specific security role defines a user's access to data and their interactions with that data. For more information, go to [Security roles and privileges](/power-platform/admin/security-roles-privileges)

The predefined security roles for Dynamics 365 Sales include permissions and access levels that the default sales personas will need. For example, the Sales Manager and Salesperson security roles can be associated with those respective users in your organization. As a system administrator, you can verify the permissions and access levels granted for each role and modify them to suit your needs. For more information, go to [Create or edit a security role](/power-platform/admin/create-edit-security-role). 

The predefined security roles are divided into the following categories:

- [Administration and customization roles](#administration-and-customization-roles)
- [Primary sales roles](#primary-sales-roles)
- [Functional roles](#functional-roles)
- [App access roles](#app-access-roles)
- [Internal roles](#internal-roles)

## Administration and customization roles

The following table lists the roles that you should assign to administrators and customizers in your organization.

| **Security roles** | **Who needs it?** | **Applies to** | **Access includes but not limited to** |
| --- | --- | --- | --- |
| System Administrator | Users who have full permission to install, configure, upgrade, customize, or administer the environment, including creating, modifying, and assigning security roles. Can view all data in the environment. |  Sales Premium, Sales Enterprise, and Sales Professional | Install, configure, customize, manage permissions, and access all the features in the application. |
| System Customizer | Users who have full permission to customize the environment. Users with this role have organization-level access to custom entities and user-level access to system entities. | Sales Premium, Sales Enterprise, and Sales Professional | Create, read, write, delete, and customizations across all features in the application. |

## Primary sales roles

The following table lists the roles that you can assign to users who need to perform primary sales tasks:  

| **Security roles** | **Who needs it?** | **Applies to** | **Access includes but not limited to** |
| --- | --- | --- | --- |
| Vice President of Sales | Users who typically manage the sales organization for several business units or the entire organization | Sales Enterprise and Sales Premium | Same permissions as the Sales Manager, except that their scope of access is broader |
| Sales Manager | Users who manage a team of sellers and are responsible for the team's performance. They're also responsible for creating and managing products, setting sales targets, and projecting sales forecasts. | Sales Enterprise and Sales Premium | Access to product management, sales management, sales forecasting, and goal management, along with the privileges of the Salesperson role. |
| Sales Professional Manager | Users who manage a team of sellers and are responsible for the team's performance. They are also responsible for creating and managing products, price lists, and unit groups. | Sales Professional | Access to product, account, and contact management, along with the privileges of the Sales Professional Person role |
| Sales Professional Person | Sellers who work on opportunities, quotes, orders, and invoices. | Sales Professional | Access to everything from lead to invoice – Lead, Opportunities, Quote, Order, Invoice.</br>Create accounts and contacts, and track goals |
| Salesperson | Sellers who work on opportunities, quotes, orders, and invoices. | Sales Enterprise and Sales Premium | Access to everything from lead to invoice – lead, opportunities, quote, order, invoice.</br>Create accounts and contacts, and track goals. |


## Functional roles

The following table lists the roles that you can assign to users who need to perform specific functions such as forecasting and playbook management: 

| **Security roles** | **Who needs it?** | **Applies to** | **Access includes but not limited to** |
| --- | --- | --- | --- |
| Forecast Manager | Sales manager or an equivalent role who's responsible for configuring forecasts in the organization. | Sales Enterprise and Sales Premium | Configure, clone, deactivate, adjust, or delete a forecast. |
| Forecast User | Any user in the organization who needs access to the forecast data for tracking and analysis | Sales Enterprise and Sales Premium | View forecast and drill-down forecast data |
| Playbook Manager | Sales manager or an equivalent role who creates playbooks for the organization. | Sales Enterprise and Sales Premium | Create playbook categories and playbook templates, and add documents to the playbook template. |
| Playbook User | Sales representative who uses playbooks while working on a record | Sales Enterprise and Sales Premium | Launch playbooks in the context of an entity, mark a playbook as completed, and track playbook activities. |
| Sequence Manager | Sales manager or an equivalent role who creates and manages sequences, segments, and assignment rules for the organization. | Sales Enterprise and Sales Premium | Create, edit, delete, and deactivate the following features in the sales accelerator<ul><li>Sequences</li><li>Segments</li><li>Assignment rules</li></ul> |

## App access roles

The following table lists the roles that you can assign to users who need to access the out-of-the-box Dynamics 365 Sales apps: 

| **Security roles** | **Who needs it?** | **Applies to** | **Access includes but not limited to** |
| --- | --- | --- | --- |
| Sales team member | Users who need to access the Sales Team Member app. This includes users who don't need the full capabilities of an enterprise application. These users will have a dedicated license, use a dedicated app, and get the Sales Team member security role to support their scenario.  More information: [Sales Team Member app for users with Team Member license](sales-team-member.md). | Sales Enterprise and Sales Premium | Access to the Sales Team Member App. Read access to contacts, accounts, leads, and opportunities. Add notes and activities, such as tasks. |
| Sales Professional app access | Users who need to access the Sales Professional app. | Sales Professional | Access to the Sales Professional app. |
| Sales, Enterprise app access | Users who need to access the Sales Hub app. | Sales Enterprise and Sales Premium | Access to the Sales Hub app. |

## Internal roles

Some roles are internally used by the product to perform certain operations. For example, the Forecast Appuser role is used to perform the forecast calculations. 
> [!NOTE]
> Don't assign these roles to any users.

The following roles are examples of internal roles:
 
- Forecast Appuser
- Sales system access
- Sales system access extension
- SalesInsights AutoCapture 

## Assign security roles to users

Associate one or more security roles to a user depending on their roles and responsibilities. For example, if a Sales Manager is also
responsible for enforcing best practices for Playbooks, assign the Sales Manager and Playbook Manager security roles to that user.

Follow these steps:

1. In the Sales Hub app, select the Settings icon in the top-right
   corner, and select **Advanced Settings**.

2. Select **Settings** in the Business Management interface, and
   go to **Security** under **System**.

3. Select **Users**, and then select the user account.

4. Select **Manage Roles**, and choose the roles that you want to assign to the user.

5. Notify the user and ask them to verify that they have the permissions they need.

### See also   

[Create users and assign security roles](/power-platform/admin/create-users-assign-online-security-roles)
