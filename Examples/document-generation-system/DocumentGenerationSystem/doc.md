# Document Generation System

### 1. Idea

Build a console-based document/report generation system that can produce reports in multiple formats like PDF, HTML, or
Markdown.
The system should support different rendering strategies, allow decoration of sections (e.g., watermark or border), and
support undoable commands like exporting or saving.

### 2. Requirement

* Allow users to generate documents in different formats (PDF, HTML, Markdown).

* Each document has sections: header, body (text/chart), and footer.

* Users can choose rendering styles (e.g., plain text, Markdown, bar chart, line chart).

* Decorate sections with features like borders, timestamps, or watermarks.

* Execute document-related actions like generate, export, save as commands.

* Notify observers of generation progress or validation errors.

* Use a centralized configuration for settings (output path, theme, font).

### 3. Design patterns:

| Design Pattern       | Purpose in the App               | Where/How It's Used                                                                                                                    |
  |----------------------|----------------------------------|----------------------------------------------------------------------------------------------------------------------------------------|
| **Abstract Factory** | Create format-specific documents | `DocumentFactory` interface with implementations: `PDFDocumentFactory`, `HTMLDocumentFactory`, etc.                                    |
| **Factory Method**   | Create document parts            | Each factory has methods like `createHeader()`, `createFooter()` returning format-specific objects.                                    |
| **Strategy**         | Dynamic rendering logic          | Sections (like `ChartSection`, `TextSection`) use rendering strategies like `PlainTextRenderingStrategy`, `BarChartRenderingStrategy`. |
| **Decorator**        | Add extra features to sections   | Wrap sections with decorators like `BorderDecorator`, `WatermarkDecorator`, `TimestampDecorator`.                                      |
| **Command**          | Encapsulate actions              | Commands like `GenerateReportCommand`, `SaveDraftCommand`, `ExportSectionCommand` that can be queued, logged, or undone.               |
| **Observer**         | Monitor progress and status      | Observers like `ProgressObserver`, `StatusObserver`, `ErrorObserver` that get updates during document generation.                      |
| **Singleton**        | Shared configuration             | A `ConfigurationManager` that holds font, path, theme, and other settings shared across the system.                                    |

### 4. Summary