---
title: Create multiple cases from an email sent to multiple mailboxes 
description: Create multiple cases from an email sent to multiple mailboxes to improve agent efficiency and response times.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 03/15/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:03/14/2024
  - ai-gen-desc
---

# Create multiple cases from an email sent to multiple mailboxes

When an email is sent to multiple mailboxes (To, CC, or BCC) which are queue-enabled in Customer Service, the email gets converted to only one case using automatic record creation rules. Multiple cases aren’t created for an email sent to multiple mailboxes.

As an administrator, enable this feature to ensure that multiple cases (one for each queue-enabled mailbox) gets created when multiple mailboxes are added as recipients in the email. With the ability to create multiple cases from an email, agents can do the following:

- With multiple cases being created, email appears in the timeline for all cases. So, agents can respond to customers’ issues independently.  

- Replies to the original email are linked to the appropriate cases.  

- Agents can see responses from the customer to outbound emails on the case timeline.

- When a customer replies to the original email adding a new queue-enabled mailbox or forwards the original email to a new queue-enabled mailbox, a new case gets created for that queue.

## Enable creation of multiple cases from an email sent to multiple mailboxes

1. Sign in to [make.powerapps.com](https://make.powerapps.com) and select your environment.
1. Select **Solutions** > **Default Solution**.
1. From **Objects**, select **Settings** > **Settings definition**.
1. Select the **Email Multi Related for ARC** setting definition.
1. On the **Edit Email Multi Related for ARC** setting dialog, **Setting environment value** section, select **New environment value**.
1. Select **Yes** for the dropdown. The **Default Value** is **No**.
1. Select **Save**.
1. Go back to **Solutions** and select **Publish all customizations**.

## How automatic record creation rules work to create multiple cases from an email sent to multiple mailboxes

After the feature is enabled, any new emails sent to multiple mailboxes get converted to multiple cases and a Related attribute (new attribute introduced on email activity to capture multiple records that an email can be associated with) is set for those cases. For more information on related attribute, see [Enable users to associate activities to multiple records (preview)](/power-apps/maker/data-platform/types-of-entities#enable-users-to-associate-activities-to-multiple-records-preview). The existing Regarding attribute for such emails will be blank. However, once the feature is turned on, for any existing email records, you’ll see the following:

- If older email records have an existing Active case set as Regarding, no new case gets created when a reply email arrives even if a new mailbox is added. The replied email gets associated with an existing case and regarding is set to the existing active case. The Related field remains empty, as no case was created.  

- If older email records have an existing Resolved case set as Regarding, and the Wait for a specific amount of time after the connected case has been resolved option is set to YES, and a reply email arrives after the time mentioned in the Select the amount of time setting, a new case gets created. The new email populates the related attribute for the reply email. If the reply email is sent to multiple mailboxes, multiple cases get created and the related field gets populated with multiple cases. The Regarding field for the reply email is set to blank.

The following flowchart explains how automatic record creation rules work to create multiple cases from an email sent to multiple mailboxes.

:::image type="content" source="../media/arc_process_flow.png" alt-text="Screenshot of automatic record creation process flow":::

### Recommendations

We recommend that you add a related attribute to your email form from the Power Apps Maker portal so that you can check which cases an email gets associated with, after it gets converted to multiple cases.

When email gets converted to multiple cases, every case has the same case title by default, as the email subject gets copied to the case title. If you would like to see which case originated in which mailbox, it is advisable to add the originating queue entries on the case form which will help you identify which case got created in which queue.

To achieve this, you may add a sub grid to list the originating queue entries to the case entity from the Power Apps Maker portal by customizing the case form.

Perform the following steps:

1. Create a new view on the msdyn_originatingqueue table. We recommend you show the msdyn_queueid and msdyn_emailid fields in the view.  

      1. Sign in to https://make.powerapps.com and select your environment.  
    
      1. Go to **Tables** > **Originating Queue Mapping** table.  
        
      1. Select **Views** from the **Data experiences** tab.  
        
      1. Select **New view**.
    
      1. On the **New view** dialog box, provide the **Name** and **Description**, and then select **Create**.
  
    We recommend you show the **Queue** and **Email** fields in the view.

1. Add a new sub-grid component to the case form for the originating queue entity.

    1. Go to **Tables** > **Case**.
    
    1. Select **Forms** from the **Data experiences** tab.
    
    1. Select the case form available in your environment.
    
    1. On the **Case** form, go to **Component** > **Grid** > **Subgrid**.  
    
    1. On the **New Case form**, **Properties** > **Display options**, fill in the following information.  

        1. **Label**: Provide a meaningful label.
        
        1. **Name**: Provide a name.  
        
        1. Select the **Show related records** checkbox.  
        
        1. Select **originatingqueue (Case)** from the **Table** drop-down list.  
        
        1. Select **the view you created in Step i**.  
        
        1. Select **Save and Publish**.

## See also

[How automatic record creation rule works in a customer scenario](arc-customer-scenario.md#how-automatic-record-creation-rule-works-in-a-customer-scenario)

[How automatic record creation rule works in an agent scenario](arc-agent-scenario.md#how-automatic-record-creation-rule-works-in-an-agent-scenario)