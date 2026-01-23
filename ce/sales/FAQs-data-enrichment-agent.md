---
title: Responsible AI FAQs about AI-powered data enrichment for opportunities
description: Learn about responsible AI considerations for the AI-powered data enrichment feature in Dynamics 365 Sales.
ms.date: 01/19/2026
ms.update-cycle: 180-days
ms.topic: faq
ms.service: dynamics-365-sales
ms.custom:
    - bap-template
    - ai-gen-docs-bap
    - ai-gen-description
    - ai-seo-date:08/04/2025
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---
# Responsible AI FAQ about AI-powered data enrichment for opportunities

These frequently asked questions help you understand the effect of AI on the AI-powered data enrichment feature in Dynamics 365 Sales.

## What is AI-powered data enrichment?

AI-powered data enrichment is an AI-driven capability in Dynamics 365 Sales that helps enrich CRM records with additional business context. It analyzes existing record information and customer emails to suggest or automatically update fields with relevant data that may be missing or incomplete. This supports users in maintaining more complete, consistent, and current CRM data.

AI-powered data enrichment can map customer conversations to the correct opportunities, capture deal signals and competitive context, and add them directly to opportunity records. When configured for automatic updates, users can review and revert changes as needed. The feature does not make business decisions on its own, and all enrichment actions are logged and auditable.

## How is the AI-powered data enrichment intended to be used?

AI-powered data enrichment is designed to support the following use cases:

- Improving the completeness of CRM records by identifying and suggesting or automatically updating missing or outdated information.
- Mapping customer emails to the correct opportunities to reduce missed or delayed CRM updates.
- Capturing deal signals, competitive context, and customer background from conversations and external sources.
- Supporting data quality initiatives by highlighting or filling gaps in record information.
- Preserving deal context for future sellers and managers by maintaining up-to-date records.

Depending on administrator configuration, AI-powered data enrichment may suggest enrichment values for user review or automatically apply updates to configured fields. When automatic updates are enabled, users can review changes and revert them if needed. All enrichment actions are auditable.

## What is AI-powered data enrichment not designed to do?

AI-powered data enrichment is not intended to:

- Make final sales decisions, qualification determinations, or business judgments
- Operate on entities or fields outside of administrator-defined configurations
- Function without the ability for human oversight, review, or reverting of changes
- Serve as a replacement for established data governance processes or human judgment

Users and administrators should treat AI-powered data enrichment as a productivity aid. When automatic updates are enabled, users should regularly review enriched fields and revert changes that are incorrect or inappropriate.


## How was AI-powered data enrichment evaluated?

AI-powered data enrichment was evaluated through testing with curated and representative CRM datasets that reflect common use patterns in Dynamics 365 Sales. Evaluation focused on the accuracy, relevance, and consistency of enrichment suggestions across different record types and business scenarios.

Testing included iterative validation cycles to assess performance under varying data quality conditions and configuration settings. Evaluation processes continue as the capability evolves.

Specific benchmarks are not provided, as performance depends significantly on the quality of source data, configuration choices, and the nature of records being enriched.

## What are the limitations of the AI-powered data enrichment? How can users minimize the effect of these limitations?

AI-powered data enrichment has several known limitations:

- **Data quality dependence**: The accuracy and relevance of suggestions depend on the quality, completeness, and currency of source data in Dataverse and connected Microsoft systems.
- **Conversation data limitations**: Email data may be incomplete if not all communications are captured in Dynamics 365, or may contain ambiguous information that affects enrichment accuracy.
- **Scope constraints**: The feature operates only on entities, fields, and languages configured by administrators, which may not cover all business needs.
- **Potential errors**: Enrichment suggestions may be incorrect, conflicting, or based on probabilistic inference rather than verified facts.
- **Coverage gaps**: Not all records or fields may receive enrichment suggestions, depending on available data and the content of customer conversations.

Users should expect that errors and omissions are possible and should validate all enriched data before relying on it for business decisions.

## How should users interpret enriched data?

Enriched data should be interpreted as suggestions or automated updates that may require human review and validation. Outputs from AI-powered data enrichment may be based on probabilistic matching, inference, or incomplete source information.

Users should:

- Regularly review fields that have been automatically enriched, especially when automatic updates are enabled
- Validate enriched values against trusted internal or external sources when accuracy is critical
- Revert any enriched data that appears incorrect, outdated, or inconsistent with known information
- Apply existing data governance and quality standards to enriched information
- Recognize that enriched data complements, but does not replace, manual research and verification

When automatic updates are configured, users can view the history of changes and revert individual field updates as needed. Enrichment is intended to accelerate workflows and improve data completeness, not to serve as an authoritative source of truth. Users remain responsible for ensuring the accuracy and appropriateness of data in their CRM records.

## What operational factors and settings allow for effective and responsible use of AI-powered data enrichment?

Administrators have several controls to manage how AI-powered data enrichment operates:

- **Enable or disable the feature**: AI-powered data enrichment can be turned on or off at the organizational level.
- **Configure scope**: Administrators define which fields must be excluded from enrichment.
- **Set update mode**: Administrators can configure whether the feature suggests values for user review or automatically updates fields.
- **Control access**: Sellers with appropriate permissions can view the suggestions on the records that they own.
- **Monitor audit logs**: All enrichment actions, including automatic updates and user reverts, are logged and can be reviewed through Dynamics 365 audit capabilities.
These controls allow organizations to tailor AI-powered data enrichment behavior to their specific governance, compliance, and operational requirements. Organizations can choose the level of automation that aligns with their data quality standards and risk tolerance.

## How does AI-powered data enrichment support responsible AI use?

AI-powered data enrichment is designed to support responsible AI use through several key principles:

- **Transparency**: Users can see which fields have been enriched and review suggestions before applying them.
- **Human oversight**: The feature is designed to assist users, not replace them, and requires human review and approval of suggestions.
- **Auditability**: Enrichment actions can be tracked and reviewed through Dynamics 365 audit and activity logs, depending on configuration.
- **Configurability**: Administrators control the scope, and exclude fields for the feature, enabling alignment with organizational policies.
- **Alignment with principles**: The design reflects Microsoft's commitment to AI principles including fairness, reliability, safety, privacy, security, inclusiveness, transparency, and accountability.

Organizations are encouraged to establish clear policies for reviewing and validating AI-generated enrichment suggestions and to train users on interpreting and using enriched data appropriately.

## Which languages are supported by AI-powered data enrichment?

AI-powered data enrichment currently supports English language only.
