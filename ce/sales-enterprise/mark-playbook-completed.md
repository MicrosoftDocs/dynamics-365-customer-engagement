---
title: "Mark a playbook as completed (Dynamics 365 Sales) | MicrosoftDocs"
description: "Close the playbook as completed to define if the playbook was successful or not."
ms.date: 02/20/2019
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
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


# Mark a playbook as completed

When you complete all the activities created for a playbook, you must mark the playbook as completed. This helps you to know if the playbook was successful or not.

1.  To mark a playbook as completed, go to the record you launched the playbook from (calling record).

2.  Select the **Related** tab, and then select **Playbooks**.

3. Open the playbook record.

4.  In the playbook record, on the command bar, select **Complete as**, and then select one of the following results:

    - Successful

    - Not Successful

    - Partially Successful

    - Not Required

    > [!NOTE]
    > A system administrator or customizer can add custom values to this field.

    > [!div class="mx-imgBorder"]
    > ![complete as button on playbook record](media/complete-playbook-as.png "Complete as button on playbook record")

### See also
[Launch a playbook to carry out activities consistently](launch-playbook.md)  
[Track playbook activities](track-playbook-activities.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]