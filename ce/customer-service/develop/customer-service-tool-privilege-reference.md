---
title: Customer Service Copilot tool privilege reference
description: Learn which Dataverse privileges each Customer Service Copilot tool requires so administrators can configure role-based access to the Service Agent tools.
ms.date: 07/28/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: lalexms
ms.author: borisvolfson
ms.reviewer: laalexan
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
ms.custom: bap-template 
---
# Privilege reference for Customer Service Copilot tools

Customer Service Copilot uses Microsoft Dataverse privileges to control which tools a user can discover and run. This article lists the privileges that each tool requires so that administrators can configure role-based access. The tools are provided by the Dynamics 365 Customer Service MCP Server and power Service Agent scenarios in Microsoft 365 Copilot.

## How tool access works

- To discover a tool, a user must have all of the privileges listed for that tool.
- Tools that aren't in the privilege map are ungated at discovery, so they're always discoverable regardless of privileges.
- If a privilege lookup fails, discovery is fail-open, so tools might still appear. However, Dataverse can still return an HTTP 403 (Forbidden) error at execution time.

## Tool-to-privilege reference

In the following table, multiple privileges are comma-separated, and a user needs all of them for the tool to be discoverable. Tools that are intentionally omitted from the privilege check are listed in [Intentionally ungated tools](#intentionally-ungated-tools).

| Tool | Required privileges |
|---|---|
| `adjust_email_tone` | `prvCreateActivity`, `prvReadActivity` |
| `answer_knowledge_question` | `prvReadKnowledgeArticle`, `prvIntelligenceUsage` |
| `answer_service_question` | `prvReadIncident` |
| `apply_email_template` | `prvReadEmailTemplate` |
| `browse_agent_config_options` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `check_harvest_status` | `prvReadKnowledgeArticle` |
| `check_knowledge_gap` | `prvReadKnowledgeArticle` |
| `close_case` | `prvReadIncident`, `prvWriteIncident`, `prvCreateActivity` |
| `create_activity` | `prvCreateActivity` |
| `create_case_from_email` | `prvCreateIncident`, `prvReadActivity` |
| `create_email_template` | `prvCreateEmailTemplate` |
| `create_note` | `prvCreateNote` |
| `delete_agent_config` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `delete_copilot_studio_registration` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `delete_mcp_registration` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `delete_profile_config` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `delete_tool_selection` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `delete_user_prefs` | `prvmsdyn_ServiceAgentUserCustomize` |
| `discard_knowledge_draft` | `prvDeleteKnowledgeArticle` |
| `draft_email` | `prvCreateActivity`, `prvReadActivity` |
| `draft_knowledge_article` | `prvCreateKnowledgeArticle` |
| `edit_email_draft` | `prvReadActivity`, `prvWriteActivity` |
| `edit_email_template` | `prvReadEmailTemplate`, `prvWriteEmailTemplate` |
| `enrich_case` | `prvWriteIncident`, `prvReadActivity` |
| `format_case_note` | `prvReadIncident` |
| `generate_email_content` | `prvReadActivity` |
| `get_account` | `prvReadAccount` |
| `get_activity_quick_create_form` | `prvCreateActivity` |
| `get_activity_timeline` | `prvReadActivity`, `prvReadNote` |
| `get_agent_config_capabilities` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `get_case` | `prvReadIncident` |
| `get_case_highlights` | `prvReadIncident`, `prvReadActivity`, `prvReadNote` |
| `get_case_next_suggestion` | `prvReadIncident`, `prvReadActivity` |
| `get_case_sla_status` | `prvReadIncident`, `prvReadSLAKPIInstance` |
| `get_contact` | `prvReadContact` |
| `get_evaluation_insights` | `prvReadmsdyn_Evaluation` |
| `get_knowledge_article` | `prvReadKnowledgeArticle` |
| `harvest_knowledge_article` | `prvCreateKnowledgeArticle` |
| `link_email_to_case` | `prvReadIncident`, `prvWriteActivity` |
| `list_accounts` | `prvReadAccount` |
| `list_agent_configs` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `list_case_inbox_workitems` | `prvReadIncident` |
| `list_case_suggested_actions` | `prvReadIncident`, `prvReadmsdyn_nextaction` |
| `list_cases` | `prvReadIncident` |
| `list_cma_drafts` | `prvReadIncident`, `prvReadActivity`, `prvReadmsdyn_copilotevent` |
| `list_cma_escalated_cases` | `prvReadIncident`, `prvReadmsdyn_aiagentstatus` |
| `list_contacts` | `prvReadContact` |
| `list_copilot_studio_registration_bots` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `list_emails` | `prvReadActivity` |
| `list_evaluations` | `prvReadmsdyn_Evaluation` |
| `list_profile_configs` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `list_tool_selection` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `list_user_prefs` | `prvmsdyn_ServiceAgentUserCustomize` |
| `manage_copilot_studio_registration` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `manage_mcp_registration` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `match_cases` | `prvReadIncident` |
| `pick_case_from_queue` | `prvReadIncident`, `prvWriteIncident` |
| `publish_knowledge_article` | `prvWriteKnowledgeArticle` |
| `query_cases_by_sla_status` | `prvReadIncident`, `prvReadSLAKPIInstance`, `prvReadQueue`, `prvReadQueueItem` |
| `reassign_case` | `prvWriteIncident`, `prvCreateNote` |
| `recommend_email_templates` | `prvReadEmailTemplate` |
| `resolve_case_and_pick_next` | `prvReadIncident`, `prvWriteIncident`, `prvCreateActivity` |
| `rewrite_structured_content` | `prvReadmsdyn_rtestructuredtemplate`, `prvReadmsdyn_rtestructuredtemplateconfig`, `prvReadmsdyn_rtetemplatemapping`, `prvCopilotRestructureContent`, `prvCreateNote` |
| `save_agent_config` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `save_copilot_studio_registration` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `save_email_template` | `prvWriteEmailTemplate` |
| `save_knowledge_draft` | `prvWriteKnowledgeArticle` |
| `save_mcp_registration` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `save_profile_config` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `save_tool_selection` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `save_user_prefs` | `prvmsdyn_ServiceAgentUserCustomize` |
| `search_knowledge_articles` | `prvReadKnowledgeArticle` |
| `search_lookup_records` | `prvReadAccount`, `prvReadContact` |
| `send_email` | `prvCreateActivity`, `prvReadActivity` |
| `show_email_template` | `prvReadEmailTemplate` |
| `submit_feedback` | `prvIntelligenceUsage` |
| `suggest_next_action_for_case` | `prvReadIncident`, `prvReadActivity`, `prvReadNote`, `prvIntelligenceUsage` |
| `summarize_account` | `prvReadAccount` |
| `summarize_case` | `prvReadIncident` |
| `summarize_case_actions` | `prvReadIncident`, `prvReadActivity` |
| `summarize_case_text` | `prvReadIncident` |
| `summarize_contact` | `prvReadContact` |
| `summarize_conversation` | `prvReadActivity` |
| `summarize_entity_timeline` | `prvReadActivity`, `prvReadNote` |
| `test_copilot_studio_registration_connection` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `test_mcp_registration_connection` | `prvmsdyn_ServiceAgentMakerCustomize` |
| `translate_email` | `prvCreateActivity`, `prvReadActivity` |
| `update_case` | `prvWriteIncident` |
| `update_knowledge_filters` | `prvReadmsdyn_copilotagentpreference`, `prvWritemsdyn_copilotagentpreference`, `prvCreatemsdyn_copilotagentpreference` |
| `update_note` | `prvWriteNote` |
| `view_email` | `prvReadActivity` |
| `view_knowledge_filter_editor` | `prvReadmsdyn_copilotagentpreference` |

## Intentionally ungated tools

The following tools are intentionally not listed in the privilege map, so they aren't gated at discovery time.

| Tool | Privilege behavior |
|---|---|
| `check_summary_enabled` | Ungated at discovery. The target setting entity has no Read privilege gate. |
| `get_entity_record` | Ungated at discovery. The entity is known only at call time. |
| `list_entity_records` | Ungated at discovery. The entity is known only at call time. |
| `update_entity_record` | Ungated at discovery. The entity is known only at call time. |
| `delete_entity_record` | Ungated at discovery. Additional server-side constraints might apply. |
| `get_environment` | Ungated at discovery. Environment management. |
| `list_environments` | Ungated at discovery. Environment management. |
| `select_environment` | Ungated at discovery. Environment management. |
| `disconnect_environment` | Ungated at discovery. Environment management. |
| `ext_{prefix}_{name}` | Synthesized external MCP tools. Not statically mapped in `TOOL_PRIVILEGE_MAP`. |
| `mcs_{name}` | Synthesized Copilot Studio tools. Not statically mapped in `TOOL_PRIVILEGE_MAP`. |

## Administrator recommendations

1. Assign privileges through role-based bundles, such as Agent, Knowledge Author, Maker Admin, and User Preferences.
1. Validate both tool visibility and runtime execution in a test environment.
1. If a user can view a tool but receives a 403 error, check the Dataverse runtime privilege enforcement for the underlying entity or action.
1. After you update roles, allow the cache time-to-live (TTL) to elapse before you re-validate visibility.

## Related information

- [Enable Service Agent in Microsoft 365 Copilot](../administer/configure-service-agent.md)
- [Connect to the Dynamics 365 Customer Service MCP Server](../administer/configure-customer-service-mcp-server.md)
- [Manage Copilot features in Customer Service](../administer/configure-copilot-features.md)
