---
title: "Enable skill-based routing and create rating model | MicrosoftDocs"
description: "Learn about how to enable skill-based routing and create rating model in Omnichannel for Customer Service app." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/15/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 4571EB48-E64E-4472-8F9F-BC55B748F972
ms.custom: 
---

# Enable skill-based routing and create rating model

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Enable skill-based routing

To use skill-based routing, as an administrator, you must enable skill-based routing in the Omnichannel for administrator app.

To enable skill-based routing, follow these steps:

1. Sign in to the Omnichannel for Administrator app.

2. Select **Skill Based Routing** under **Settings** in the sitemap.

3. Select **Yes** for the **Enable Skill Based Routing** field.

4. Select a rating model from the list for the **Rating Model** field. <br> By default, Default Rating Model is appears if your environment has Universal Resource Scheduling. <br> If there is no rating mode, create a new rating model. To learn more, see [Create new rating model](enable-skill-routing-create-rating-model.md#create-rating-model).

5. Select **Save**.

## Rating value of skills

For each skill you add to an agent, you need a way to rate the proficiency of the skill. This enables the system to do an exact or closest match against the requirement of a conversation and distribute the conversation accordingly. You can use the default rating model, edit it, or create a new one to match the needs of your organization.

You must provide the minimum and maximum rating value. Also, in the **Rating Values** section, you must create rating value text against each score between the minimum and maximum rating value. This text appears while updating an agent's skill and proficiency.

### Create rating model

1. Sign in to the Omnichannel for Administrator app.

2. Select **Skill Based Routing** under **Settings** in the sitemap.

3. Select **+ New** in the **Routing Model** lookup option. The **New Rating Model** page appears.

4. Specify the following in the **New Rating Model** page.

    | Tab | Field | Description | Example value  |
    |------------|-----------------|----------------|--------------------------------------------|
    | General | Name | Specify a name for the rating model. | Language rating model |
    | General | Min Rating Value | Provide the minimum rating value. | 1 |
    | General | Max Rating Value | Provide a maximum rating value. | 10 |

5. Select **Save** to save the rating model. After you save, the **Rating Values** section appears.

6. Select **+ Add New Rating Value**. The **Rating Value** page appears.

7. Specify the following in the **Rating Value** page.

    | Tab | Field | Description | value  |
    |------------|-----------------|----------------|--------------------------------------------|
    | General | Name | Specify a name for the rating model. | Very Good <br> **Note:** <br>This is an example value.|
    | General | Value | Provide a value. | 10 <br> **Note:** <br>This is an example value.|
    | General | Is Default | Set this rating value as a default value while defining the proficiency level. | Yes |

8. Select **Save** to save the rating value.

9. Select **+ New** to add other rating values and repeat step 7 and 8.


### Recommended proficiency level

It is recommended to use a rating model with minimum value as 1 and maximum value as 10, and define the rating values accordingly.

For example:

| Rating Value Name | Value |
|-------------------|-------|
| Advanced level A | 10 |
| Advanced level B | 9 |
| Advanced level C | 8 |
| Intermediate level A | 7 |
| Intermediate level B | 6 |
| Intermediate level C | 5 |
| Beginner lever A | 4 |
| Beginner lever A | 3 |
| Beginner lever A | 2 |
| Don't know | 1 |

## See also

[Overview of skill-based routing](overview-skill-work-distribution.md)

[Set up skills and assign agents](setup-skills-assign-agents.md)

[Attach skills to conversation](attach-skills.md)