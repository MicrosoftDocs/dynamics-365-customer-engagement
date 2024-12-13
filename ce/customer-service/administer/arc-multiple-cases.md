---
title: Create multiple cases from an email sent to multiple mailboxes 
description: Create multiple cases from an email sent to multiple mailboxes to improve the efficiency and response times of customer service representatives.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 12/13/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:03/14/2024
  - ai-gen-desc
---


# Create multiple cases from an email sent to multiple mailboxes

When an email is sent to multiple mailboxes (To, Cc, or Bcc) that are queue-enabled in Customer Service, the email gets converted to only one case using automatic record creation rules. Sometimes, [multiple cases do get created for an email sent to multiple mailboxes](arc-faqs.md#why-do-multiple-cases-get-created-from-a-single-email) but the email gets associated only to one case and is displayed on one of the case timelines only.

As an administrator, you can enable this feature to ensure that multiple cases (one for each queue-enabled mailbox) are created when multiple mailboxes are added as recipients in the email. With the ability to create multiple cases from an email, customer service representatives (service representatives) can do the following:

- With multiple cases being created, email appears in the timeline for all cases. So, service representatives can respond to customers’ issues using any case timeline.

- Replies to the original email are linked to the appropriate cases.  

- Service representatives can see responses from the customer to outbound emails on the case timeline.

- When a customer replies to the original email adding a new queue-enabled mailbox or forwards the original email to a new queue-enabled mailbox, a new case is created for that queue.

## Enable creation of multiple cases from an email sent to multiple mailboxes

1. Sign in to [powerapps.com](https://make.powerapps.com), and then select the environment that contains your solution.
1. From **Objects**, select **Settings** > **Settings definition**.
1. Select the **Email Multi Related for ARC** setting definition.
1. On the **Edit Email Multi Related for ARC** setting dialog, in the **Setting environment value** section, select **New environment value**.
1. Select **Yes** for the dropdown list. The **Default Value** is **No**.
1. Select **Save**.
1. Go back to **Solutions** and select **Publish all customizations**.

## How automatic record creation rules work to create multiple cases from an email sent to multiple mailboxes

After the feature is enabled, any new emails sent to multiple mailboxes are converted to multiple cases, and a **Related** attribute (new attribute introduced on email activity to capture multiple records that an email can be associated with) is set for those cases. For more information on related attributes, see [Enable users to associate activities to multiple records (preview)](/power-apps/maker/data-platform/types-of-entities#enable-users-to-associate-activities-to-multiple-records-preview). The existing **Regarding** attribute for such emails are blank. However, once the feature is turned on, for any existing email records, you see the following actions:

- If older email records have an existing **Active** case set as **Regarding**, no new case gets created when a reply email arrives, even if a new mailbox is added. The replied email gets associated with an existing case, and **Regarding** is set to the existing active case. The **Related** field remains empty, as no case was created.  

- If older email records have an existing **Resolved** case set as **Regarding**, and the **Wait for a specific amount of time after the connected case has been resolved** option is set to **YES**, and a reply email arrives after the time mentioned in the **Select the amount of time** setting, a new case is created. The related attribute of the reply email is populated with the newly created case. If the reply email is sent to multiple mailboxes, multiple cases are created and the related field is populated with multiple cases. The **Regarding** field for the reply email isn't set. However, the **Regarding** field for the previous correlated email isn't impacted.

The following flowchart explains how automatic record creation rules work to create multiple cases from an email sent to multiple mailboxes.

:::image type="content" source="../media/arc-process-flow.png" alt-text="Screenshot of automatic record creation process flow":::

### Recommendations

- We recommend that you add a related attribute to your email form from the Power Apps Maker portal, so that you can check which cases an email gets associated with after it gets converted to multiple cases. The related column isn't added to an email form by default. To enable users to use this new column, add the **Related** column to the email form. For information about how to add a column to a form, go to [add columns to a form](/power-apps/maker/model-driven-apps/add-move-or-delete-fields-on-form).

- When email gets converted to multiple cases, every case has the same case title by default, as the email subject gets copied to the case title. If you want to see which case originated in which mailbox, it's advisable to add the originating queue entries on the case form, which helps you identify which case got created in which queue.

    To achieve this, you can add a subgrid to list the originating queue entries to the case entity from the Power Apps Maker portal by customizing the case form.

    Perform the following steps:

    1. Create a new view on the msdyn_originatingqueue table. We recommend you show the msdyn_queueid and msdyn_emailid fields in the view.  

       1. Sign in to [powerapps.com](https://make.powerapps.com), and then select your environment.  
    
       1. Go to **Tables** > **Originating Queue Mapping**.  
        
       1. Select **Views** from the **Data experiences** tab.  
        
       1. Select **New view**.
    
       1. On the **New view** dialog box, provide the **Name** and **Description**, and then select **Create**.
  
    We recommend you show the **Queue** and **Email** fields in the view.

    1. Add a new subgrid component to the case form for the originating queue entity.

       1. Go to **Tables** > **Case**.
    
       1. Select **Forms** from the **Data experiences** tab.
    
       1. Select the case form available in your environment.
    
       1. On the **Case** form, go to **Component** > **Grid** > **Subgrid**.  
    
       1. On the **New Case form**, **Properties** > **Display options**, fill in the following information:  

          - **Label**: Provide a meaningful label.
        
          - **Name**: Provide a name.  
        
          - Select the **Show related records** checkbox.  
        
          - Select **originatingqueue (Case)** from the **Table** dropdown list.  
        
          - Select the view you created in Step 1.  
        
          - Select **Save and Publish**.

## Related information

[How the automatic record creation rule works in a customer scenario](arc-customer-scenario.md#how-the-automatic-record-creation-rule-works-in-a-customer-scenario)

[How the automatic record creation rule works in an customer service representative scenario](arc-agent-scenario.md#how-the-automatic-record-creation-rule-works-in-an-agent-scenario)

[Sample - ARC Multi-Related - Remove Unreferenced Queue](sample-arc-multiple-cases.md#sample---arc-multi-related---remove-unreferenced-queue)
