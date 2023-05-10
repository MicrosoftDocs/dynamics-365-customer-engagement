---
title: "Launch a playbook to carry out activities consistently (Dynamics 365 Sales) | MicrosoftDocs"
description: "Playbooks lets you consistently perform recurrent business processes such as a sales process."
ms.date: 05/08/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_playbookinstance
  - D365-Entity-msdyn_playbookactivity
  - D365-Entity-msdyn_playbookactivityattribute
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Launch a playbook to carry out activities consistently 

> [!NOTE]
> Starting July 7, 2023, playbooks will be deprecated region-wise. Move your playbook templates to sequences to create scheduled and conditional workflows. [Learn more](create-manage-sequences.md)  

To ensure consistency in your business process or to know what steps to follow in certain scenarios or events, rely on the playbooks prepared by your managers that guide you with the actions you can take. Playbooks can also contain best practices based on practices that have worked in similar situations before.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Launch a playbook

1. Make sure you have the **Playbook user** role or equivalent permissions.

2.  Go to the record you want to launch playbook from. For example, if you know your organization has playbooks created for opportunities, open an opportunity record.

3.  On the command bar, select **Launch playbook**.

     > [!div class="mx-imgBorder"]
     > ![launch playbook button on opportunity record.](media/launch-playbook-button-opportunity.png "Launch playbook button on opportunity record")  

    > [!NOTE]
    > The **Launch playbook** button appears on an entity form only when there’s at least one published playbook template for that entity. If you do not see this button, talk to your playbook manager.

4.  In the **Playbook templates** dialog box, select a playbook that you want to use, and then select **Launch**.

    You’ll see a notification “Playbook launched successfully.”

    > [!NOTE]
    > You can launch only one playbook at a time.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also
[Track playbook activities](track-playbook-activities.md)  
[Enforce best practices with playbooks](enforce-best-practices-playbooks.md)  
[Mark playbook as completed](mark-playbook-completed.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
