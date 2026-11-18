---
title: Responsible AI FAQ for Dynamics 365 Activate
description: Get answers to frequently asked questions about the use of AI in the Salesforce migration experience in Dynamics 365 Activate.
ms.date: 11/18/2026
ms.update-cycle: 180-days
ms.topic: faq
ms.service: dynamics-365-sales
ms.collection: bap-ai-copilot
ms.custom:
  - bap-template
  - responsible-ai-faq
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: zobanyai
ai-usage: ai-generated
---

# Responsible AI FAQ for Dynamics 365 Activate

These frequently asked questions help you understand the effect of AI on the Salesforce migration experience in Dynamics 365 Activate.

## What is Dynamics 365 Activate?

Dynamics 365 Activate is an application that helps you assess a Salesforce environment and migrate selected CRM data to Dynamics 365 Sales and Dynamics 365 Customer Service. It brings discovery, migration planning, mapping, schema deployment, data migration, and reconciliation into one experience.

## What are the AI-assisted capabilities of Dynamics 365 Activate?

AI-assisted analysis helps you assess your Salesforce environment and review migration recommendations. The discovery and assessment experience includes:

- **Source environment assessment**: Review discovered objects, fields, relationships, automation, code, and dependencies.
- **Migration planning guidance**: Review complexity scores, migration readiness ratings, and recommended migration approaches.
- **Assessment reports**: Share discovery findings and recommendations with stakeholders and project teams.

These outputs support migration planning. They don't replace a review of your source configuration. The application assesses automation and code, including Salesforce flows and Apex, but doesn't automatically convert or migrate them. For the supported migration scope, see [Salesforce to Dynamics 365 migration overview](migrate-salesforce-to-dynamics-365-overview.md).

## How is AI-assisted analysis in Dynamics 365 Activate intended to be used?

AI-assisted analysis is intended to help implementation teams understand an existing Salesforce environment, identify migration work, and decide what to preserve, redesign, or exclude. It's a decision-support tool for people who can review Salesforce configuration and the target Dynamics 365 design. It isn't intended to replace their judgment or decision-making.

Don't use AI-assisted recommendations as the sole basis for migration scope, effort estimates, or deployment decisions. Review the results with the people responsible for your business processes and application configuration.

## How was AI-assisted analysis in Dynamics 365 Activate evaluated? What metrics are used to measure performance?

Product-specific AI evaluation results and performance metrics aren't documented in this FAQ. Migration readiness ratings and complexity scores describe the assessed Salesforce components; they aren't measures of AI accuracy.

Validate recommendations against your source configuration and business requirements before acting on them. Migration reconciliation and business-process testing validate migration outcomes; they don't replace evaluation of the AI-assisted analysis.

## What are the limitations of AI-assisted analysis in Dynamics 365 Activate? How can users minimize the effect of these limitations?

- **Incomplete or incorrect analysis**: AI-generated recommendations might miss a business rule, dependency, or customization that matters to your organization.
- **Discovery scope**: The configured Salesforce integration user's permissions determine which supported metadata and records the application can access. Missing or inaccessible information can limit the assessment.
- **Automation and code**: The application assesses Salesforce flows, Process Builder processes, workflow rules, and Apex, but doesn't automatically convert or migrate them.
- **Language support**: English is the only supported language.
- **Migration validation**: An assessment doesn't establish that a migration is complete or that the target application behaves as required.

To minimize the effect of these limitations:

- Compare recommendations with the relevant Salesforce configuration and discovery results.
- Investigate discovery areas that appear empty or incomplete, and verify that the integration user has the required access.
- Review dependencies, business rules, and customizations with your application owners.
- Plan separate work to redesign or replace automation and code.
- Reconcile migrated records and test business processes before using the target environment in production.

For discovery scope and permission guidance, see [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md).

## What data does Dynamics 365 Activate use for discovery and assessment?

Discovery reads supported Salesforce metadata, configuration, and aggregate information available to the integration user, including:

- **Schema definitions**: Objects, fields, relationships, and picklist values.
- **Automation and code**: Flows, workflow rules, Process Builder processes, and Apex classes and triggers.
- **Application configuration**: Lightning pages, installed packages, integrations, localization settings, and licenses.
- **Aggregate information**: Record counts, field population rates, and user counts by profile.

These are discovery inputs, not a specification of the data sent to an AI model. Migration is a separate process that reads the records you select and writes mapped records to the target Dynamics 365 environment.

## What data is shared with external services?

Dynamics 365 Activate connects to Salesforce to read source information and to Dynamics 365 to discover target schema and migrate selected data. For application-level data access, storage, retention, and security guidance, see [Security and data handling for Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-security.md).

## What operational factors and settings allow for effective and responsible use of Dynamics 365 Activate?

- **Configure least-privilege access**: Use only source and target environments that you're authorized to access. Assign connection users the permissions required for your discovery and migration scope.
- **Verify discovery results**: Compare discovered objects and fields with your source configuration before relying on the assessment.
- **Review mappings**: Validate object, field, user, and ownership mappings against your target design.
- **Test before production**: Test schema deployment and migration in a nonproduction Dynamics 365 environment.
- **Validate outcomes**: Reconcile migrated records and test the business processes before using the target environment in production.
- **Report issues**: Use the application feedback option to report incomplete or incorrect AI-assisted analysis.

For the migration workflow and validation steps, see [How to migrate from Salesforce to Dynamics 365](migrate-salesforce-to-dynamics-365-quick-start.md).

## How can I provide feedback about AI-assisted analysis?

Use the feedback option in Dynamics 365 Activate, rather than the documentation feedback option on this page.

1. Select **Feedback** in the application footer.
2. In the **Area** dropdown, select **AI Analysis**.
3. Describe what you expected, what the analysis showed, and the steps needed to reproduce the issue.
4. Submit the feedback.

Don't include credentials, access tokens, or sensitive customer data in your feedback.

## Related information

- [Dynamics 365 Activate overview](dynamics-365-activate-overview.md)
- [Access and set up Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-access-setup.md)
- [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md)
- [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md)
