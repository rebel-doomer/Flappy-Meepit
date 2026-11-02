---
name: organize-scratchpad
description: >-
  Organizes the thought dump: regroup, add subjects, and prune or mark done
  after asking. Use when the user asks to organize, regroup, cluster, tidy,
  update, prune, clean out, or drop scratchpad / dump notes.
disable-model-invocation: true
---

# Organize Scratchpad

## When to use

Only when the human asks to organize, regroup, prune, update, or clean the dump. Do not run unprompted. Read-only overview → `/brief-scratchpad`.

## Instructions

1. Read `.cursor/scratchpad.md` — it is the source of truth.
2. List open notes by **subject** (or first line if none) — not full bodies.
3. Propose changes, then **ask before rewriting**:
   - Regroup / cluster / add or shorten subjects.
   - Mark done or delete: shipped, duplicates, empty rambles, finished one-offs.
   Numbered list is fine. They pick numbers, "delete all flagged", "organize only", or "none".
4. After they pick, rewrite `.cursor/scratchpad.md`:
   - Keep `# Scratchpad` and the one-line purpose blurb.
   - `### Open` / `### Done`.
   - Each note: `#### <!--id:...-->`, optional `**subject**`, then body. Preserve ids on keepers.
   - Do not invent new notes. Empty notes can be dropped.
5. Do not expand dump items into a project plan.
6. Say what you regrouped, marked done, removed, and left open.

## Examples

- `/organize-scratchpad`
- "organize my scratchpad"
- "prune the dump"
- "what can I drop"
