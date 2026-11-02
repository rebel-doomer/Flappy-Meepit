---
name: brief-scratchpad
description: >-
  Reads the thought dump and gives a short briefing: open notes, themes,
  what looks stale. Use when the user asks what’s in the dump, a summary,
  a briefing, or catch-me-up on scratchpad / thought dump notes. Do not rewrite the dump.
disable-model-invocation: true
---

# Brief Scratchpad

## When to use

Only when invoked (`/brief-scratchpad`) or the human asks what’s in the thought dump. Do not brief unprompted mid-task. Do not rewrite `.cursor/scratchpad.md` — that’s `/organize-scratchpad`.

## Instructions

1. Read `.cursor/scratchpad.md`. Open notes matter; Done is optional unless they ask.
2. Reply in chat only. Do not edit the dump, rules, or skills.
3. Keep it short:
   - Counts: open vs done.
   - Themes (a few groups), each with **subject** if present, else a one-line title — not full bodies.
   - Stale or duplicate-looking open notes, if any.
4. Do not start work from dump items. Do not expand notes into a plan unless they pick one after the brief.
5. If the dump is empty, say so in one line.

## Examples

- `/brief-scratchpad`
- "what’s in the dump"
- "brief my scratchpad"
