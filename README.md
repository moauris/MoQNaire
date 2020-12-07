# MoQNaire
An Examination Presenter based on WPF. Part of the C# Learn Through Example Initiative.

MoQNaire takes questionnaires in form of xml files, and present it as part of its library.

It then allows for user to pick which question set to begin test, then it begins a localized test session.

## Learning Goal

The goals for this project is to make an application to learn and implement the below WPF design principles:

- MVVM design pattern
- Building Application with API and extensibilities
- Dependency Injection
- User login and registration via email validation (might require interoperability)
- Other impromptu learning opportunities along the way 

## UI Design and workflow idea

Upon launch, user should be able to see a login prompt.

After validating credentials, user will see the main GUI.

On the left column is a series of user control tabs showing some basic functionalities, such as:

- Home - Back to the default page
- My Score - a page that displays historical scores
- My Subjects - a page that displays the subjects in the Exam Collection Objects
- Customize Exam - a page that allows user to build and save customized exams with question sets
- About - a page that displays version info and other meta info

## Object design

### MoQNaire.ExamSession

An object representing a test session. It contains:

- Name of the test session, might be detailed into different different parts
- A `TimeSpan` object representing the session time
- A set of questions / answers pairs
- A score object that displays percent of completion and rate of correct answers
- A setting object that stores the setting of current running exam, such as immediate feedback mode, individual timer mode, hide timer mode, untimed mode, no remorse mode, etc.
- A difficulty, an enum representing the difficulty of this test

During the exam session, an participant will start with these questions, and fulfill questions one by one. After the exam is completed, a scoreboard will be displayed.

### MoQNaire.Question (Question Set)

An object representing a question in a question set. It contains:

- (Optional) a name of the question
- Question statement
- a collection of answers, with the correct one
- Allowed answering time

For simplification, all questions are only in the form of options.

A question set object is simply the collection of multiple questions.



