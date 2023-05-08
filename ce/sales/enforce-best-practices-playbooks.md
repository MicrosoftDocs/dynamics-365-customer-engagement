---
title: "Enforce best practices with playbooks (Dynamics 365 Sales) | MicrosoftDocs"
description: "Guide your team members with predefined activities to ensure that they follow a consistent approach on recurrent events or scenarios."
ms.date: 05/08/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - dyn365-sales
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_playbookactivity
  - D365-Entity-msdyn_playbooktemplate
  - D365-Entity-msdyn_playbookactivityattribute
  - D365-Entity-msdyn_playbookcategory
  - D365-Entity-msdyn_playbookinstance
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Enforce best practices with playbooks

> [!NOTE]
> Starting July 7, 2023, playbooks will be discontinued region-wise. Move your playbook templates to sequences to create scheduled and conditional workflows. [Learn more](create-manage-sequences.md)  

Use playbooks in [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] to guide team members on how to respond to events when a decision maker leaves an organization while the team is working on a deal with that decision maker, for example. The playbook defines an organization's best-practices response to such an event. Playbooks can also streamline and automate recurring tasks such as renewing contracts. 

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** |  Playbook manager, Playbook user <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## How does it work

To start, a team member with a **Playbook manager** role or equivalent permissions creates playbook categories to classify the playbooks. Then, the playbook manager creates playbook templates that define a set of best practices based on past experiences and their organization's standards. A business user such as a sales person or service rep who has been assigned a **Playbook user** role can then open one of these playbook templates while they work on their records. The playbook template helps ensure that best practices are applied consistently at every step.

 
<div class="embeddedvideo"><iframe src="https://www.microsoft.com/videoplayer/embed/RE2OLrb" frameborder="0" allowfullscreen=""></iframe></div>
 

> [!NOTE]
> The playbook capability is currently available only in the Sales Hub app of Dynamics 365 Sales. 
> To learn about updating an app solution, see [Install, update, or remove a preferred solution](/power-platform/admin/install-remove-preferred-solution). 

### See also
[Define playbook categories](define-playbook-categories.md)  <br>
[Manage playbook templates](manage-playbook-templates.md) <br>
[Associate documents with playbook activities](associate-documents-playbook-activities.md)  
[Launch a playbook to carry out activities consistently](launch-playbook.md)  <br>
[Mark playbook as completed](mark-playbook-completed.md)  <br>
[Track playbook activities](track-playbook-activities.md)  <br>
[What's new in Dynamics 365 Sales](whats-new.md)<br />
[Entity reference for playbooks](developer/reference/playbook-entity-reference.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
