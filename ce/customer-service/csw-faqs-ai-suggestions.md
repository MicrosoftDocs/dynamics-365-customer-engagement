---
title: FAQs for AI suggestions for cases, knowledge articles | MicrosoftDocs
description: FAQs for AI suggestions for cases and knowledge articles in Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 11/17/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365CS
---

# FAQs on AI suggestions for cases and knowledge articles

A few answers to common questions on the AI-suggested similar cases and knowledge articles are listed here.

## I’ve enabled suggestions, but smart assist keeps showing me "No suggestions found" message

It may be caused by one of the following reasons:

- If it’s the first time you've enabled suggestions, it may take up to 24 hours to complete the pre-processing from your existing published knowledge articles and resolved cases before suggestions will be displayed.
- The first time pre-process operation handles up to 1,500 published knowledge articles and 10,000 resolved cases from the most recent ones. Older articles and resolved cases are not picked up from the first time pre-processing, so they won’t be surfaced as suggestions.
- Suggestions are displayed for only active cases. Suggestions are updated when an active case is created or updated.
- The case title or description is not clear enough to describe the problem, therefore, the model can't find articles or similar cases that match what's described.



## I get an error message that the selected language is not supported.

You need to make sure that your language setting matches one of the languages supported by AI suggestions. For more information on the supported languages and language settings, see [Language support for AI suggestions](csw-enable-ai-suggested-cases-knowledge-articles.md#Language-support-for-ai-suggestions).

## I get an error message that detected language doesn't match the language settings.

he AI model is used to detect the language of the cases and conversations. If the language detected doesn't match the language in the settings or if the language is not supported, suggestions are not displayed. If the case or conversation doesn’t contain enough information or contains mixed languages, the AI model may not be able to detect the language correctly.More information on how language support works, see  [Language support for AI suggestions](csw-enable-ai-suggested-cases-knowledge-articles.md#Language-support-for-ai-suggestions).

## I get an error message in Suggestions settings page, “We couldn’t pre-process the case records or knowledge articles”. What should I do?

Check if all the [prerequisites](csw-enable-ai-suggested-cases-knowledge-articles.md#prerequisites) have been met for generating the models. 
Particularly, 

- Make sure all required [workflow processes](csw-enable-ai-suggested-cases-knowledge-articles.md#workflow-processes) installed with the feature are activated.
-  Background operations are enabled when administration mode is enabled in the environment. For how to update the administration mode, see  see [Administration Mode](/power-platform/admin/admin-mode). 

If everything is correctly enabled but the error message still appears on the settings page the next day, contact Microsoft Support.

## I've added more details about the problem in an active case, but the suggestions are not refreshed at all

You are required to reopen the case form to see new suggestions.

## I can’t see smart assist with suggestions expanded at all when I open a case

Make sure that the case is opened in a session tab. To open it in a session tab, select the case using Shift+mouse click.

### See also

[Enable AI-suggestions for similar cases and knowledge articles](csw-enable-ai-suggested-cases-knowledge-articles.md)  
[View AI-suggested similar cases and knowledge articles](csw-view-ai-suggested-cases-knowledge-articles.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]