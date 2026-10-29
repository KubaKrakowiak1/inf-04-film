import { useState } from 'react';
import './App.css';

function App() {
  const [form, setForm] = useState({
    tytul: '',
    rodzaj: '',
  });

  const change = (e) => {
    setForm({
      ...form,
      [e.target.name]: e.target.value,
    });
  };

  const submit = (e) => {
    e.preventDefault();

    console.log('tytul: ' + form.tytul + '; rodzaj: ' + form.rodzaj);
  };
  return (
    <>
      <form onSubmit={submit}>
        <div className="mb-3">
          <label htmlFor="tytulFilm" className="form-label">
            Tytuł filmu
          </label>
          <input
            type="text"
            className="form-control"
            id="tytulFilmu"
            name="tytul"
            value={form.tytul}
            onChange={change}
          />
        </div>

        <div className="mb-3">
          <label htmlFor="rodzajFilmu" className="form-label">
            Rodzaj
          </label>

          <select
            className="form-select"
            id="rodzajFilmu"
            name="rodzaj"
            value={form.rodzaj}
            onChange={change}
          >
            <option value=""> </option>
            <option value="1">Komedia </option>
            <option value="2">Obyczajowy </option>
            <option value="3">Sensacyjny </option>
            <option value="4">Horror </option>
          </select>
        </div>

        <button type="submit" className="btn btn-primary">
          Dodaj
        </button>
      </form>
    </>
  );
}

export default App;
/*
nazwa klasy: App

pola:

form – przechowuje dane formularza: tytuł filmu oraz jego rodzaj.
tytul – przechowuje tytuł filmu.
rodzaj – przechowuje rodzaj filmu.

metody:
change(e) – nie zwraca wartości – aktualizuje stan formularza na podstawie wprowadzonych danych.
submit(e) – nie zwraca wartości – obsługuje wysłanie formularza i wyświetla tytuł oraz rodzaj filmu w konsoli przeglądarki.

informacje: Program umożliwia wprowadzenie tytułu filmu, wybranie jego rodzaju z listy oraz wyświetlenie wprowadzonych danych w konsoli przeglądarki po kliknięciu przycisku „Dodaj”. Aplikacja została napisana w języku JavaScript z wykorzystaniem biblioteki React.

*/
