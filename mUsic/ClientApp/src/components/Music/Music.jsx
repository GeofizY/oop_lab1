import React from 'react'
import MusicElement from './Music.module.scss'

const Music = (props) => {
    return (
        <li className={MusicElement.music}>
            <div className={MusicElement.nameAndDuration}>
                <span className={MusicElement.musicName}>{props.name}</span>
                <span className={MusicElement.musicDuration}>{props.duration}</span>
            </div>
            <span className={MusicElement.musicExInfo}>{props.author}, {props.album}, {props.collection}</span>
        </li>
    )
}

export default Music