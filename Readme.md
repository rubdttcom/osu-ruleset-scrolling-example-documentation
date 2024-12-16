# Readme (EN)

_(Readme en español, más abajo)_

I have built in this repository the Documentation that has been useful for me to effectively understand the Template of the osu! Ruleset `ruleset-scrolling-example`.

The documentation follows a folder structure identical to the code. For a user-friendly reading experience, I recommend using Obsidian and opening the folder of the language you are interested in within Obsidian, as you will be able to navigate through the internal links conveniently.

## Process

To build this documentation, I used GPT4o with the following prompt + the content of each `.cs` file:

```
Can you explain the class MyCoolWorkingRulesetRuleset considering its dependencies and references to other classes and methods?
```

The responses have been slightly edited to remove "typical" LLM text, such as "How else can I help you?" and similar phrases.

The original documentation was generated in Spanish.

To translate the documentation into English, I used the `gemma-2-27b-it` model by [bartwoski](https://huggingface.co/bartowski/gemma-2-27b-it-GGUF) with a custom Python utility to translate markdown file blocks, using a prompt like the following:

```python
messages = [
                {
                    "role": "system",
                    "content": (
                        "Translate the provided markdown text into the specified target language, "
                        "retaining the original formatting (headings, lists, code blocks, etc.), "
                        "and return only the translated text without any extra explanations."
                    )
                },
                {
                    "role": "user",
                    "content": f"Please translate the following markdown content to {target_language}:\n\n{block}"
                }
            ]
```

Since this documentation has been generated with LLMs, it may be imprecise, contain errors, propose examples that do not work, are not useful, or do not make sense. I am just beginning to learn about osu! Rulesets and do not yet have the criteria to evaluate the quality of the responses. Thank you for your understanding.

## Notice

This repository contains a copy of the osu! Ruleset Template `ruleset-scrolling-example` as of 2024-12-14 in the `code` folder. To obtain the most recent copy of this Template, visit [Templates](https://github.com/ppy/osu/tree/master/Templates) in the official osu! repository. I do not recommend using the code in this repository to build your ruleset.

The reason for including a "frozen" version of this code is to maintain consistency with the documentation contained in this repository, as it is possible that this repository will never be updated again or at least not at the pace the osu! team considers appropriate.

I am not part of or linked in any way to the osu! team. This repository is a selfless initiative for my own training in the development of osu Rulesets!

---
---

# Readme (ES)

He construido en este repositorio la Documentación que me ha sido útil para comprender de manera eficaz la Template del Ruleset de osu! `ruleset-scrolling-example`.

La documentación sigue una estructura de carpetas idéntica a la del código. Para una lectura amigable te recomiendo usar Obsidian, y abrir la carpeta del idioma que te interese en Obsidian, ya que podrás navegar a través de los enlaces internos cómodamente.

## Proceso

Para construir esta documentación utilicé GPT4o con el siguiente prompt + el contenido de cada fichero `.cs`:

```
puedes explicarme la clase MyCoolWorkingRulesetRuleset teniendo en cuenta sus dependencias y referencias a otras clases y metodos?
```

Las respuestas han sido levemente editadas para eliminar "texto típico" de LLM, como "¿en qué más te puedo ayuda?" y esas cosas.

La documentación original se ha generado en español.

Para realizar la traducción a inglés de la documentación utilicé el modelo `gemma-2-27b-it` de [bartwoski](https://huggingface.co/bartowski/gemma-2-27b-it-GGUF) con una utilidad python propia para traducir bloques de ficheros markdown, con un prompt como el siguiente:

```python
messages = [
                {
                    "role": "system",
                    "content": (
                        "Translate the provided markdown text into the specified target language, "
                        "retaining the original formatting (headings, lists, code blocks, etc.), "
                        "and return only the translated text without any extra explanations."
                    )
                },
                {
                    "role": "user",
                    "content": f"Please translate the following markdown content to {target_language}:\n\n{block}"
                }
            ]
```

Debido a que esta documentación ha sido generada con LLMs podría ser imprecisa, contener errores o proponer ejemplos que no funcionen o no sean útiles o que no tengan sentido. Yo estoy empezando a aprender acerca de los Rulesets de osu! y tampoco tengo el criterio para evaluar la calidad de las respuestas, gracias por tu comprensión.

## Aviso

Este repositorio contiene una copia del Template del Ruleset de osu! `ruleset-scrolling-example` a fecha 2024-12-14 en la carpeta `code`, para obtener la copia más reciente de este Template dirígete a [Templates](https://github.com/ppy/osu/tree/master/Templates) en el repositorio oficial de osu! No te recomiendo que utilices el código de este repositorio para construir tu ruleset.

El motivo para incluir una versión "congelada" de este código es para mantener la coherencia con la documentación que contiene este repositorio, ya que es posible que este repositorio no se actualice nunca más o almenos al ritmo que el equipo de osu! considere.

No formo parte ni estoy vinculado de ninguna manera al equipo de desarrollo de osu! Este repositorio es una íniciativa desinteresada para mi propia formación en el desarrollo de Rulesets de osu!

---
---

# License (code folder)


*osu!*'s code and framework are licensed under the [MIT licence](https://opensource.org/licenses/MIT). Please see [the licence file](https://github.com/ppy/osu/blob/master/LICENCE) for more information. [tl;dr](https://tldrlegal.com/license/mit-license) you can do whatever you want as long as you include the original copyright and license notice in any copy of the software/source.

Please note that this *does not cover* the usage of the "osu!" or "ppy" branding in any software, resources, advertising or promotion, as this is protected by trademark law.

Please also note that game resources are covered by a separate licence. Please see the [ppy/osu-resources](https://github.com/ppy/osu-resources) repository for clarifications.


# License (docs folders)

Documentations are licensed under the [MIT license](https://opensource.org/licenses/MIT). Please see [the license file](LICENSE) for more information. [tl;dr](https://tldrlegal.com/license/mit-license) you can do whatever you want as long as you include the original copyright and license notice in any copy of the software/source.
