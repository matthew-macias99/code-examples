import { useState } from 'react';
import './App.css';
import Question from './components/Question';
import Score from './components/Score';
import Header from './components/Header';
import Footer from './components/Footer';


const quizQuestions = [
  {
    question: "What is the purpose of useState in React?",
    options: [
      "To manage state in a functional component",
      "To handle side effects",
      "To perform HTTP requests",
      "To create a new component"
    ],
    answer: "To manage state in a functional component"
  },
  {
    question: "What does JSX stand for?",
    options: [      
      "JavaScript",
      "JavaScript XML",
      "Java Styling Extension",
      "JavaScript Syntax Expression"
    ],
    answer: "JavaScript XML"
  },
  {
    question: "Which hook is used to handle side effects in functional components?",
    options: [
      "useState",
      "useEffect",
      "useReducer",
      "useContext"
    ],
    answer: "useEffect"
  },
  {
    question: "What are the limitations of React?",
    options: [
      "React is a full-blown framework",
      "The components of React aren't that complicated",
      "It might be difficult for beginner programmers to understand React",
      "React is not that complex"
    ],
    answer: "It might be difficult for beginner programmers to understand React"
  },
  {
    question: "What does JSX allow you to do?",
    options: [
      "Write HTML inside JavaScript and place them in the DOM without using functions",
      "Write CSS inside JavaScript and HTMl without using functions",
      "Create desktop applications using JavaScript and HTML",
      "Create web applications without the use of HTML"
    ],
    answer: "Write HTML inside JavaScript and place them in the DOM without using functions"
  },
  {
    question: "What is the virtual DOM?",
    options: [
      "A fake DOM used for testing purposes",
      "A virtual representation of the real DOM kept inside memory",
      "A virtual version of the DOM created to use before deploying a site",
      "A concept that has only been theorized"
    ],
    answer: "A virtual representation of the real DOM kept inside memory"
  },
  {
    question: "What are React Hooks?",
    options: [
      "A tool used within class components",
      "Something that lets you connect methods together",
      "Functions that let you hook into React state and lifecycle features",
      "Simplified ways to start a project"
    ],
    answer: "Functions that let you hook into React state and lifecycle features"
  },
  {
    question: "What is React?",
    options: [
      "A JavaScript framework",
      "A coding language",
      "A Javascript library",
      "A non-reuseable UI tool"
    ],
    answer: "A Javascript library"
  },
  {
    question: "Which method is used to pass data from parent to child components?",
    options: [
      "Props",
      "State",
      "Context API",
      "Redux"
    ],
    answer: "Props"
  },
  {
    question: "Which of these best describes a React component?",
    options: [
      "A CSS rule used in styling",
      "A reuseable piece of UI defined as a function or class",
      "A database used in React projects",
      "A special HTML element only available in React"
    ],
    answer: "A reuseable piece of UI defined as a function or class"
  }
];


const App = () => {
  const [currentQuestion, setCurrentQuestion] = useState(0);
  const [score, setScore] = useState(0);
  const [showScore, setShowScore] = useState(false);
  const [selectedOption, setSelectedOption] = useState('');


  const handleOptionChange = (e) => {
    setSelectedOption(e.target.value);
  };


  const handleNextQuestion = () => {
    if (selectedOption === quizQuestions[currentQuestion].answer) {
      setScore(score + 1);
    }


    setSelectedOption('');


    if (currentQuestion < quizQuestions.length - 1) {
      setCurrentQuestion(currentQuestion + 1);
    } else {
      setShowScore(true);
    }
  };


  const handleRestartQuiz = () => {
    setCurrentQuestion(0);
    setScore(0);
    setShowScore(false);
    setSelectedOption('');
  };


  return (
    <div className="quiz-app">
      <Header />    
      {showScore ? (
        <Score score={score} totalQuestions={quizQuestions.length} handleRestartQuiz={handleRestartQuiz} />
      ) : (
        <Question
          questionData={quizQuestions[currentQuestion]}
          selectedOption={selectedOption}
          handleOptionChange={handleOptionChange}
          handleNextQuestion={handleNextQuestion}
          currentQuestion={currentQuestion}
          totalQuestions={quizQuestions.length}
        />
      )}
      <Footer />
    </div>
  );
};


export default App;





