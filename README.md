# MarcusMedina.Units.Volume

[![NuGet](https://img.shields.io/nuget/v/MarcusMedina.Units.Volume.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Volume/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/MarcusMedina.Units.Volume.svg?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/MarcusMedina.Units.Volume/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=for-the-badge&logo=csharp&logoColor=white)](#)
[![.NET](https://img.shields.io/badge/.NET-10.0+-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)
[![Open Source](https://raw.githubusercontent.com/MarcusMedinaPro/MarcusMedina.Units.Volume/main/assets/open-source.svg)](https://opensource.org)
[![Build](https://img.shields.io/github/actions/workflow/status/MarcusMedinaPro/MarcusMedina.Units.Volume/release.yml?branch=main&label=Build&style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Volume/actions)
[![Signed](https://img.shields.io/badge/Signed-Sigstore-green?style=for-the-badge&logo=linux)](https://docs.sigstore.dev)
[![Wiki](https://img.shields.io/badge/docs-wiki-blue?style=for-the-badge&logo=github)](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Volume/wiki)

**Fluent volume unit conversion for .NET 10+** — metric, US customary, British imperial, and historical Swedish units.

Convert between milliliters, liters, gallons, kanna and more with a strongly-typed `Volume` struct — no more guessing which raw `double` means what, and no more mixing up a US gallon with a UK gallon by accident.

> These came to me while I was sitting with upper-secondary students, helping them work through their maths homework. They saw calculations; I saw code. We'd break each problem down into small pieces so it was easier to grasp, and then they'd work through it themselves — usually landing on "oh, so that's all it was?" after sitting there feeling completely lost about what the task even wanted from them. Helping them was genuinely fun, and it's what got me thinking about turning those exact tasks into code.
>
> In this case, I wanted each unit conversion to be broken into the same small, obvious steps I'd walk a student through by hand, not buried inside a single formula.

---

## Features

- ✅ **Metric** — nL, µL, mL, cL, dL, L, daL, hL, kL, cm³, mm³, m³
- ✅ **US customary** — teaspoon, tablespoon, fluid ounce, cup, pint, quart, gallon (US)
- ✅ **British imperial** — teaspoon, tablespoon, fluid ounce, gill, pint, quart, gallon (UK) — deliberately kept separate from US units of the same name, since 1 UK gallon ≈ 4.546 L while 1 US gallon ≈ 3.785 L
- ✅ **Historical Swedish** — jungfru, stop, kanna, ankare, tunna
- ✅ **Strongly typed** — `Volume` struct instead of a raw `double`, so units can't be mixed up by accident
- ✅ **Fluent API** — `1.GallonUK().ToLiters()`
- ✅ **Comparable & arithmetic** — `+`, `-`, `*`, `/`, and full comparison operators
- ✅ **Zero dependencies** — pure .NET, no external packages

---

## Installation

```bash
dotnet add package MarcusMedina.Units.Volume
```

**Requirements:** .NET 10.0+, C# 14.0+

---

## Quick Start

```csharp
using MarcusMedina.Units.Volume.Metric;
using MarcusMedina.Units.Volume.British;
using MarcusMedina.Units.Volume.SwedishOld;

// Create a Volume from any supported unit
Volume bottle = 1.5.Liters();
Volume cask   = 1.Ankare();

// Convert to whatever unit you need
double gallonsUK = bottle.ToGallonUK();   // ≈ 0.33
double liters    = cask.ToLiters();       // ≈ 39.27

// Arithmetic works directly on Volume values
Volume total = bottle + 1.GallonUK();

// Comparisons
bool bigger = cask > bottle;
```

---

## API Overview

| Namespace | Unit family |
|-----------|-------------|
| `MarcusMedina.Units.Volume.Metric` | nL, µL, mL, cL, dL, L, daL, hL, kL, mm³, cm³, m³ |
| `MarcusMedina.Units.Volume.US` | teaspoon, tablespoon, fluid ounce, cup, pint, quart, gallon (US) |
| `MarcusMedina.Units.Volume.British` | teaspoon, tablespoon, fluid ounce, gill, pint, quart, gallon (UK) |
| `MarcusMedina.Units.Volume.SwedishOld` | jungfru, stop, kanna, ankare, tunna |

Every unit exposes a creation extension (`1.Kanna()`) and a conversion extension
(`volume.ToKanna()`). The `Volume` struct itself always stores the value in milliliters,
so mixing units in the same expression is always safe.

---

## Testing

```bash
cd csharp
dotnet test --configuration Release
```

Tests: **17 passed** — covering all unit families, arithmetic operators, and edge cases.

---

## License

MIT — see [LICENSE](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Volume/blob/main/LICENSE) for details.

---

## Built with Human + AI Collaboration

This library was written by **Marcus Medina** together with **Claude Code** (Anthropic) — not through "vibe coding" where you just describe and accept, but through genuine collaboration: planning together, reviewing each other's decisions, pushing back when something felt wrong, and iterating until the result felt right.

The goal was always to write code worth reading and code worth using — the kind a student can open, understand, and learn from, and the kind any programmer can drop into real, professional work without wanting to rewrite it from scratch. AI was a partner in that process, not a shortcut around it.

If you're curious about this way of working, the source code and git history are open. Every decision has a reason behind it.

## Made for Curious Minds

This library was built with students in mind — not as a black box to copy and paste, but as a real-world example of how clean, purposeful code is written and shared.

Whether you're discovering C# for the first time, need a reliable helper for your school project, or are simply trying to fall in love with writing code — you're exactly who this was made for.

The source is open. Read it, fork it, break it, improve it. That's the whole point.

And if this library saved you an afternoon, or made something click that didn't before — that's everything.

*Non-students are equally welcome. Good code doesn't care about your diploma.*

⭐ If this helped you, consider starring the project on GitHub — it helps other students find it too.

💬 Have an idea, a feature request, or just want to say hi? Open an issue on GitHub — I'd love to hear from you.

## Package Integrity

All releases are signed with [cosign](https://docs.sigstore.dev) (Sigstore keyless signing).

To verify a downloaded package, download both the `.nupkg` and its `.sigstore.json` bundle from the [GitHub Release](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Volume/releases), then run:

```bash
cosign verify-blob <package.nupkg> \
  --bundle <package.nupkg.sigstore.json> \
  --certificate-identity-regexp "https://github.com/MarcusMedinaPro/.*/release.yml" \
  --certificate-oidc-issuer https://token.actions.githubusercontent.com
```

Expected output: `Verified OK`

## Related Projects

- [MarcusMedina.Units.Area](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Area) — Fluent area unit conversion
- [MarcusMedina.Units.Weight](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Weight) — Fluent weight unit conversion
- [MarcusMedina.Units.Math](https://github.com/MarcusMedinaPro/MarcusMedina.Units.Math) — Unit-aware mathematical operations
- [MarcusMedina.Maths.Algebra](https://github.com/MarcusMedinaPro/MarcusMedina.Maths.Algebra) — Algebraic expressions and symbolic math
