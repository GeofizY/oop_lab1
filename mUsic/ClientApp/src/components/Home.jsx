import React, { useState, useEffect } from "react"
import Music from "./Music/Music"
import Category from "./Category/Category"

const Home = () => {

    const [allSongs, setSongs] = useState([])

    const getSongs = async () => {
        const options = {
            method: 'GET'
        }
        const result = await fetch(`/api/songs`, options)
        if (result.ok) {
            const songs = await result.json()
            setSongs(songs)
            return songs
        }
        return []
    }

    useEffect(() => {
        getSongs()
    }, [])

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
                        <button className='searchButton'>
                            <div className='dividingLine'> </div>{" "}
                            <img
                                src='./icons/Search_Zoom.svg'
                                alt='search'
                                className='header_search_zoom'
                            />
                        </button>{" "}
                    </div>{" "}
                    <ul className='musicList'>
                        {allSongs.map(song => {
                            return <Music
                                name={song.name}
                                duration={(song.duration / 60).toFixed(2)}
                            // author='None'
                            // album='None'
                            // collection='None'

                            />
                        })}
                    </ul>{" "}
                </section>{" "}
            </main>{" "}
        </div>
    )
}

export default Home