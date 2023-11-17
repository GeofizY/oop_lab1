import React, { Component } from "react"
import Music from "./Music/Music"
import Category from "./Category/Category"

export class Home extends Component {
    static displayName = Home.name

    render() {
        return (
            <div className='bg'>
                <div className='logo'> мУзычка </div>{" "}
                <main className='main'>
                    <aside className='filter'>
                        <div className='articleFilter'> Фильтр </div>{" "}
                        <div className='chooseFilter'>
                            <Category
                                firstCategory='Жанр'
                                firstSubcategory='Рок'
                                secondSubcategory='Поп'
                                thirdSubcategory='Электро'
                            />
                            <Category
                                firstCategory='Жанр'
                                firstSubcategory='Рок'
                                secondSubcategory='Поп'
                                thirdSubcategory='Электро'
                            />
                            <Category
                                firstCategory='Жанр'
                                firstSubcategory='Рок'
                                secondSubcategory='Поп'
                                thirdSubcategory='Электро'
                            />
                        </div>{" "}
                    </aside>{" "}
                    <section className='searchAndMusic'>
                        <div className='searchBox'>
                            <input
                                type='text'
                                placeholder='Название, автор, альбом или сборник'
                                maxLength='100'
                                className='searchText'
                            />
                            <div className='searchButton'>
                                <div className='dividingLine'> </div>{" "}
                                <img
                                    src='./icons/Search_Zoom.svg'
                                    alt='search'
                                    className='header_search_zoom'
                                />
                            </div>{" "}
                        </div>{" "}
                        <ul className='musicList'>
                            <Music
                                name='Пластинки'
                                duration='3:05'
                                author='Дурной Вкус'
                                album='Сингл'
                                collection='Вне сборника'
                            />
                            <Music
                                name='Пластинки'
                                duration='3:05'
                                author='Дурной Вкус'
                                album='Сингл'
                                collection='Вне сборника'
                            />
                            <Music
                                name='Пластинки'
                                duration='3:05'
                                author='Дурной Вкус'
                                album='Сингл'
                                collection='Вне сборника'
                            />
                            <Music
                                name='Пластинки'
                                duration='3:05'
                                author='Дурной Вкус'
                                album='Сингл'
                                collection='Вне сборника'
                            />
                            <Music
                                name='Пластинки'
                                duration='3:05'
                                author='Дурной Вкус'
                                album='Сингл'
                                collection='Вне сборника'
                            />
                            <Music
                                name='Пластинки'
                                duration='3:05'
                                author='Дурной Вкус'
                                album='Сингл'
                                collection='Вне сборника'
                            />
                        </ul>{" "}
                    </section>{" "}
                </main>{" "}
            </div>
        )
    }
}
