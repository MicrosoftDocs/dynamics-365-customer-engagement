---
title: "Enable skill-based routing and create rating model | MicrosoftDocs"
description: "Learn about how to enable skill-based routing and create rating model in Omnichannel for Customer Service app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/13/2019
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Enable skill-based routing and create rating model

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Enable skill-based routing in Customer Service admin center<a name="sbr-cs-admin"></a>

### Manual skill identification ruleset

Procedure to create ruleset manually

### ML-based skill identification ruleset

*Procedure to create ruleset using ML*



## Enable skill-based routing in Omnichannel Administration<a name="sbr-oc-admin"></a>

To use skill-based routing, as an administrator, you must enable skill-based routing in the Omnichannel Administration app.

To enable skill-based routing, follow these steps:

1. Sign in to the Omnichannel Administration app.

2. Select **Skill Based Routing** under **Settings** in the sitemap.

3. On the **Skill Based Routing** tab, set the **Enable Skill Based Routing** toggle to **Yes**.

4. Select a rating model from the list for the **Rating Model** field.
 
    If there is no rating model, create a rating model. To learn more, see [Create rating model](enable-skill-routing-create-rating-model.md#create-rating-model).

    After you select a rating model, the **Rating Model Details** section displays the **Name**, **Min Rating Value**, **Max Rating Value** and the **Rating Values (Rating Model)** grid.

    Use the following steps to add a rating value in the grid:

    1. Select **New Rating Value**. The **Quick Create: Rating Value** pane appears.

    2. Specify a name and value.

    3. Select **Save and Close** to save and add the rating value.

5. Select **Save**.

## Rating value of skills

When you add a skill to an agent, you also need to rate the proficiency of the skill. This enables the system to do an exact or closest match against the requirement of a conversation and distribute the conversation accordingly. You can use the default rating model, edit it, or create a new one to match the needs of your organization.

You must provide the minimum and maximum rating value. Also, in the **Rating Values** section, you must create rating value text against each score between the minimum and maximum rating value. This text appears while updating an agent's skill and proficiency.

### Create rating model

1. Sign in to the Omnichannel Administration app.

2. Select **Skill Based Routing** under **Settings** in the sitemap.

3. Select **New Rating Model** in the **Rating Model** section. The **New Rating Model** page appears.

4. Specify the following in the **New Rating Model** page.

    | Tab | Field | Description | Example value  |
    |------------|-----------------|----------------|--------------------------------------------|
    | General | Name | Specify a name for the rating model. | Language rating model |
    | General | Min Rating Value | Provide a minimum rating value. | 1 |
    | General | Max Rating Value | Provide a maximum rating value. | 10 |

5. Select **Save** to save the rating model. After you save, the **Rating Values** section appears.

6. Select **New Rating Value**. The **Quick Create: Rating Value** pane appears.

7. Specify the following in the **Rating Value** page.

    | Field | Description | Value  |
    |-----------------|----------------|--------------------------------------------|
    | Name | Specify a name for the rating value. | ★★★★★★★★★★ <br> **Note:** <br>This is an example value.|
    | Value | Provide a value. | 10 <br> **Note:** <br>This is an example value.|

8. Select **Save and Close** to save and add the rating value to the grid.

9. Select **+ New** to add other rating values and repeat step 7 and 8.

10. Select **Save** to save the rating model changes.

### Recommended proficiency level

We recommend that you use a rating model with minimum value as 1 and maximum value as 10, and define the rating values accordingly.

For example:

| Rating value name | Value |
|-------------------|-------|
| ★★★★★★★★★★| 10 star|
| ★★★★★★★★★ | 9 star|
| ★★★★★★★★ | 8 star|
| ★★★★★★★ | 7 star |
| ★★★★★★ | 6 star|
| ★★★★★ | 5 star|
| ★★★★ | 4 star|
| ★★★ | 3 star|
| ★★ | 2 star|
| ★ | 1 star|

### See also

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Set up skills and assign agents](setup-skills-assign-agents.md)  
[Attach skills to conversation](attach-skills.md)  
