---
title: "Predefined security roles for Sales (Dynamics 365 Sales) | MicrosoftDocs"
description: "Predefined security roles define permissions and access levels specific to different sales personas. Assign users to appropriate security roles to grant them adequate access to the system."
ms.date: 04/23/2021
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
# Predefined security roles for Sales

Security roles control users access to data through a set of access levels and permissions. The combination of access levels and permissions that are included in a specific security role defines  users access to data and their interactions with that data. For more information, see [Security roles and privileges](/power-platform/admin/security-roles-privileges)

The predefined security roles for Sales include permissions and access levels that the default sales personas will need. For example, the Sales Manager and Salesperson security roles can be associated with the respective users in your organization. As a system administrator, you can verify the permissions and access levels granted for each role and modify it to suit your needs. For more information, see [Create or edit a security role](/power-platform/admin/create-edit-security-role).

| **Security roles** | **Who needs it?** | **Access granted** |
|-------------------------|------------|-------------------------|
| Sales Manager | Users who manage a team of sellers and are responsible for the team's performance. They are also responsible for creating and managing product SKUs, setting sales targets, and projecting sales forecasts. | Access to product management, sales management, sales forecasting, and goal management. |
| Salesperson | Sellers who work on opportunities, quotes, orders, and invoices. | Access to everything from lead to order – Lead, Opportunities, Quote, Order, Invoice.</br>Create accounts and contacts, and track goals |
| Sales team member | Users who don't need the full capabilities of an enterprise application. These users will have a dedicated license, use a dedicated app, and get the Sales Team member security role to support their scenario.  More information: [Sales Team Member app for users with Team Member license](sales-team-member.md). | Access to the Sales Team Member App. Read access to contacts, accounts, leads, and opportunities. Add notes and activities, such as tasks. |
| Vice President of Sales | Users who typically manage the sales organization for several business units or the entire organization. | Same permissions as the Sales Manager, except that their scope of access is broader. |
| Forecast Manager | Sales manager or an equivalent role who is responsible for configuring forecasts in the organization.  | Configure, clone, deactivate, adjust, or delete a forecast. |
| Forecast user | Any user in the organization who needs access to the forecast data for tracking and analysis  | View forecast and drill-down forecast data |
|Forecast Appuser  | System security role. Do not assign this role to any users. |Internal role used by Dynamics 365 to perform certain forecasting opertions. |
| Playbook Manager | Sales manager or an equivalent role that creates playbooks for the organization. | Create playbook categories and playbook templates, and add documents to the playbook template. |
| Playbook User | Sales representatives who use playbooks while working on a record | Launch playbooks in the context of an entity, mark a playbook as completed, and track playbook activities. |
|  |  |  |


## Assign security roles to users

Associate one or more security roles to a user depending on their roles and responsibilities. For example, if a Sales Manager is also
responsible for enforcing best practices for Playbooks, assign the Sales Manager and Playbook Manager security roles to that user.

**Follow these steps:**

1. In the Sales Hub app, select the Settings icon in the top-right
   corner, and select **Advanced Settings**.

2. Select **Settings** in the Business Management interface, and
   go to **Security** under **System**.

3. Select **Users**, and then select the user account.

4. Select **Manage Roles**, and choose the roles that you want to assign to the user.

5. Notify the user and have them check their permissions.

### See also
[Create users and assign security roles](power-platform/admin/create-users-assign-online-security-roles.md)
