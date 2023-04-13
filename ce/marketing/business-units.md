---
title: "Control access to Marketing records with business units (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how business units affect users and record visibility in Dynamics 365 Marketing."
ms.date: 02/09/2021
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Use business units to control access to Marketing records

Business units are a standard feature of model-driven apps, or a logical grouping of linked business operations (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation). Admins can use business units to control access to records based on who is using the app and who owns each record. Business units are mapped to an organization's departments or divisions, therefore if your organization is structured around departments or divisions with separate products, customers, and segments, you might consider creating business units.

## How business units affect Dynamics 365 Marketing

### General effects of business units

For complete details about how business units work in model-driven apps in Dynamics 365, see [Create or edit business units](/power-platform/admin/create-edit-business-units). Here's a quick summary of concepts that are relevant to understanding business units:

- Every user belongs to exactly one business unit.
- Each record belongs to the same business unit as the record owner. The record owner can be a user or team. By default, the record owner is the user that created it, although records can be reassigned by users with sufficient permissions.
- Business units can be hierarchical. The top business unit is called the _organization_ business unit; it's created by default and can't be removed. In a simple setup, this might be the only business unit present. A slightly more complex setup may have a single tier of business units below this one (these are also called). A complex setup might have a full tree with several branches of hierarchical business units.
- Restricted users have security roles that grant them _user-level access_ to the relevant entities. This limit their access to include only those records that they themselves own.
- Standard users have security roles that grant them _business-unit level access_ to the relevant entities. This allows them to access records belonging to other users from their own business unit (business-unit access).
- Advanced users, such as managers, have security roles that grant them _parent-level access_ to the relevant entities. This allows them to access records belonging to users in their own business unit plus all child (lower-tier) business units.
- Privileged users, such as admins, have security roles that grant them _organization-level access_ to the relevant entities. This allows them to access records belonging to all business units.
- Teams can also combine with business units to affect record access. A record can be owned by a team rather than a user, in which case the record becomes part of the team's business unit. Teams can likewise combine users from different business units, in which case members of that team see other team members' records as though they were all in the same business unit. More information: [Manage teams](/power-platform/admin/manage-teams)

## Use business units in outbound or real-time marketing

- [Business unit support in outbound marketing](business-units-support-outbound-marketing.md)
- [Business unit support in real-time marketing](real-time-marketing-business-units.md)
- [Support for modernized business units ](real-time-marketing-modernized-business-units.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]