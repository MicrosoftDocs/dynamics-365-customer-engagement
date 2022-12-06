---
title: Prevent duplicate workflows with knowledge article operations
description: Learn how to prevent duplicate workflows with knowledge article operations. 
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.service: dynamics-365
ms.topic: how-to
ms.date: 12/06/2022
ms.custom: bap-template
---

# Prevent duplicate workflows with knowledge article operations

If you use [workflow processes](../customerengagement/on-premises/customize/workflow-processes.md) to perform knowledge article operations, such as creating or updating a knowledge article, the update operation is further classified into suboperations, such as:

-	Update a knowledge article version.
-	Manage a knowledge article version.
-	Translate a knowledge article.

For the create and update operations, be aware of the following when using the workflow process: 

Whenever you create a new knowledge article manually, the system creates two articles: a root article and a base article. This means if you use a workflow process that is triggered on a create operation, the workflow is triggered twice—once each for the creation of the base article and the root article.

When you use a workflow process to perform the following update operations, the workflow is triggered twice—once each for the base article and the root article:
-	Create major version
-	Create minor version
-	Translate
  
   > [!NOTE]
   >  Other update operations, such as updating a field or approve/publish, do not trigger the second workflow.

To avoid triggering the workflow twice, in the workflow itself, set the trigger condition for the knowledge article as follows: 

- For a create operation, set the root article to **Yes**.
- For an update operation, set the root article to **No**.

Perform these steps:
  
1. Sign in to Customer Service Hub.  
  
2. Select **Settings** > **Advanced Settings**. Advanced Settings opens in a new browser tab.
  
3. In the navigation bar, select **Settings** > **Processes**.

4. Select the knowledge article flow you created. The workflow process opens in a new browser window.
  
5. In the **General** tab, select the **Add Step** dropdown list, and then select **Check Condition**. A new step will be added.

    > [!div class=mx-imgBorder]
    > ![Select Check Condition.](media/workflows-check-condition.png "Select Check Condition from the Add Step dropdown list")
  
6. In the step, select **&lt;condition&gt; (click to configure)**. The **Specify condition** page opens in a new browser window.

    > [!div class=mx-imgBorder]
    > ![Select the condition to configure.](media/workflows-configure-condition.png "Select the condition to configure")
  
7. From the entity dropdown list, select **Knowledge Article**.

8. From the field dropdown list, select **Root Article**.

9. From the condition dropdown list, select **Equals**.

10. From the value dropdown list, select a value:
    - **Yes** for the create operation.
    - **No** for the update operation.

    > [!div class=mx-imgBorder]
    > ![Set workflow condition.](media/workflows-set-condition.png "Select the applicable value for the workflow condition from the dropdown list")

11.	Select **Save and Close** to save the condition and close the window.

12.	In the workflow process window, select **Save and Close** to save the condition and close the window.

Now, when you perform a create or update operation, the workflow process will trigger only once.
