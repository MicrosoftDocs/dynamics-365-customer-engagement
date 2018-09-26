---
title: "Track playbook activities (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Carry out the playbook activities to ensure every event or scenario is dealt with consistently."
keywords: "playbook, activities, track, progress"
ms.date: 10/01/2018
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 7727c370-1c75-40e9-9319-250994f61bec
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Tech Reviewing
---

# Track playbook activities

When a playbook is launched, its related activities are created and associated with the record the playbook is launched from (also called calling record). You must complete these activities to ensure every event is dealt with consistently.

If the playbook template used for the playbook has **Track status** field set to **Yes**, the activities are created under the playbook record under the calling record. If **Track status** field is set to **No**, the activities are created directly under the calling record.

To see the activities created by the playbook when Track progress field in the playbook template is set to **Yes**:

1.  Go to the record you launched playbook from. For example, if you launched playbook from an opportunity record, go to the opportunity record.

2.  Select the **Related** tab, and then select **Playbooks**.

 ![playbooks option in related tab on opportunity record](media/playbooks-option-related-tab-opportunity-record.png "Playbooks option in Related tab on opportunity record")  

3.  In the **Playbook Associated View**, the playbook launched from the record is listed.

 ![playbooks tab on opportunity record](media/playbooks-tab-opportunity-record.png "Playbooks tab on opportunity record")  

4.  Select the playbook.

    The playbook record shows all the details about the playbook and its associated activities.

 ![playbook record with associated playbook activities](media/playbook-record-with-associated-activities.png "Playbook record with associated playbook activities")  

    For example, it shows when the playbook was launched, how many total activities it has, how many of the activities are completed, and what’s the estimated close date. It also shows all the related playbook activities in the **Playbook activities** section. Work on these activities, and when you are done, mark them as completed.

    To see the activities if **Track status** field of the playbook template is set to **No**, in the calling record, see the Timeline section.

    Alternately, in the calling record, select the **Related** tab, and then select **Activities**.

 ![activities tab on the opportunity record](media/activities-tab-opportunity-record.png "Activities tab on the Opportunity record")  

    This view shows all the activities for the calling record along with the ones created when a playbook was launched. However, it doesn’t show how many are created in context of a playbook.


### See also
[Launch a playbook to carry out activities consistently](launch-playbook.md)  
[Define best practices with playbooks](enforce-best-practices-playbooks.md)  
[Mark playbook as completed](mark-playbook-completed.md)